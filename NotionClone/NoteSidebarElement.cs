using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotionClone
{
    public partial class NoteSidebarElement : UserControl
    {
        string DataPath;
        public event EventHandler<string> FileDoubleClicked;

        public NoteSidebarElement(string title, string path)
        {
            InitializeComponent();

            TitleLabel.Text = title;
            DataPath = path;

            this.DoubleClick += NoteSidebarControl_DoubleClick;
        }

        private void NoteSidebarControl_DoubleClick(object sender, EventArgs e)
        {
            FileDoubleClicked?.Invoke(this, DataPath);
        }
    }
}
