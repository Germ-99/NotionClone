using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace NotionClone
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        enum DwmWindowAttribute : uint
        {
            DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
            DWMWA_MICA_EFFECT = 38,
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, DwmWindowAttribute attr, ref int attrValue, int attrSize);

        string DataPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Notion Clone");
        string CurrentPath;
        bool Saving = false;

        public Form1()
        {
            InitializeComponent();
            TopPanel.MouseDown += TopPanel_MouseDown;
            ThemeAllControls();
        }

        private void ThemeAllControls(Control parent = null)
        {
            parent = parent ?? this;
            Action<Control> Theme = control => {
                int trueValue = 0x01;
                SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
                DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref trueValue, Marshal.SizeOf(typeof(int)));
                DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_MICA_EFFECT, ref trueValue, Marshal.SizeOf(typeof(int)));
            };
            if (parent == this) Theme(this);
            foreach (Control control in parent.Controls)
            {
                Theme(control);
                if (control.Controls.Count != 0)
                    ThemeAllControls(control);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreLoadNotes();
            timer1.Start();
        }

        private void PreLoadNotes()
        {
            LoadNotes();
            if (!string.IsNullOrEmpty(CurrentPath))
            {
                LoadNote(CurrentPath);
            }
        }

        private void LoadNotes()
        {
            NotePanel.Controls.Clear();

            if (!Directory.Exists(DataPath))
            {
                Directory.CreateDirectory(DataPath);
                return;
            }

            var files = Directory.GetFiles(DataPath, "*.json");

            if (string.IsNullOrEmpty(CurrentPath) && files.Length > 0)
            {
                CurrentPath = files[0];
            }

            foreach (var file in files)
            {
                try
                {
                    string Json = File.ReadAllText(file);
                    var note = JsonSerializer.Deserialize<Dictionary<string, string>>(Json);

                    if (note.ContainsKey("title"))
                    {
                        NoteSidebarElement NSE = new NoteSidebarElement(note["title"], file);
                        NSE.FileDoubleClicked += SidebarNoteClicked;
                        NotePanel.Controls.Add(NSE);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading note: {ex.Message}");
                }
            }
        }

        private async void SidebarNoteClicked(object sender, string directory)
        {
            if (!string.IsNullOrEmpty(CurrentPath))
            {
                SaveNote(TitleBox.Text, ContentBox.Text, CurrentPath);
            }

            CurrentPath = directory;
            LoadNote(directory);
            LoadNotes();
        }

        private void SaveNote(string title, string content, string path)
        {
            if (Saving) return; 
            Saving = true;

            try
            {
                if (!Directory.Exists(DataPath))
                {
                    Directory.CreateDirectory(DataPath);
                }

                var Note = new
                {
                    title = title,
                    content = content
                };

                string FilePath;

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    FilePath = path;
                }

                else
                {
                    int fileNumber = 1;
                    do //Thank you claude for this do thing
                    {
                        FilePath = System.IO.Path.Combine(DataPath, $"{fileNumber}.json");
                        fileNumber++;
                    } while (File.Exists(FilePath));

                    CurrentPath = FilePath;
                }

                File.WriteAllText(FilePath, JsonSerializer.Serialize(Note, new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
                Saving = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error saving note: {ex.Message}");
            }
        }

        private void LoadNote(string path)
        {
            if (!File.Exists(path)) return;

            try
            {
                string Json = File.ReadAllText(path);
                var note = JsonSerializer.Deserialize<Dictionary<string, string>>(Json);

                if (note != null)
                {
                    TitleBox.Text = note["title"];
                    ContentBox.Text = note["content"];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading note: {ex.Message}");
                TitleBox.Clear();
                ContentBox.Clear();
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentPath))
            {
                SaveNote(TitleBox.Text, ContentBox.Text, CurrentPath);
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentPath) && !Saving)
            {
                SaveNote(TitleBox.Text, ContentBox.Text, CurrentPath);
            }
        }
    }
}