namespace NotionClone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNewNote = new FontAwesome.Sharp.IconPictureBox();
            this.NotePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.RichTextBox();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TrashButton = new FontAwesome.Sharp.IconPictureBox();
            this.MoreButton = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonMin = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonMax = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonClose = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNewNote)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrashButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.ButtonNewNote);
            this.SidePanel.Controls.Add(this.NotePanel);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(223, 805);
            this.SidePanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Notes";
            // 
            // ButtonNewNote
            // 
            this.ButtonNewNote.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNewNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ButtonNewNote.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.ButtonNewNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ButtonNewNote.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonNewNote.IconSize = 27;
            this.ButtonNewNote.Location = new System.Drawing.Point(185, 89);
            this.ButtonNewNote.Name = "ButtonNewNote";
            this.ButtonNewNote.Size = new System.Drawing.Size(27, 27);
            this.ButtonNewNote.TabIndex = 18;
            this.ButtonNewNote.TabStop = false;
            this.ButtonNewNote.Click += new System.EventHandler(this.ButtonNewNote_Click);
            // 
            // NotePanel
            // 
            this.NotePanel.Location = new System.Drawing.Point(12, 117);
            this.NotePanel.Name = "NotePanel";
            this.NotePanel.Size = new System.Drawing.Size(200, 600);
            this.NotePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s Notion";
            // 
            // TitleBox
            // 
            this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TitleBox.Location = new System.Drawing.Point(422, 157);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(687, 66);
            this.TitleBox.TabIndex = 1;
            this.TitleBox.Text = "Title";
            this.TitleBox.Click += new System.EventHandler(this.TitleBox_Click_1);
            // 
            // ContentBox
            // 
            this.ContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ContentBox.Location = new System.Drawing.Point(422, 229);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(687, 534);
            this.ContentBox.TabIndex = 2;
            this.ContentBox.Text = resources.GetString("ContentBox.Text");
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.TrashButton);
            this.TopPanel.Controls.Add(this.MoreButton);
            this.TopPanel.Controls.Add(this.ButtonMin);
            this.TopPanel.Controls.Add(this.ButtonMax);
            this.TopPanel.Controls.Add(this.ButtonClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(223, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1080, 35);
            this.TopPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.panel1.Location = new System.Drawing.Point(36, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 21);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // TrashButton
            // 
            this.TrashButton.BackColor = System.Drawing.Color.Transparent;
            this.TrashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TrashButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.TrashButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.TrashButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.TrashButton.IconSize = 27;
            this.TrashButton.Location = new System.Drawing.Point(41, 5);
            this.TrashButton.Name = "TrashButton";
            this.TrashButton.Size = new System.Drawing.Size(27, 27);
            this.TrashButton.TabIndex = 20;
            this.TrashButton.TabStop = false;
            this.TrashButton.Visible = false;
            this.TrashButton.Click += new System.EventHandler(this.TrashButton_Click);
            // 
            // MoreButton
            // 
            this.MoreButton.BackColor = System.Drawing.Color.Transparent;
            this.MoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.MoreButton.IconChar = FontAwesome.Sharp.IconChar.Ellipsis;
            this.MoreButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.MoreButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MoreButton.IconSize = 27;
            this.MoreButton.Location = new System.Drawing.Point(6, 5);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(27, 27);
            this.MoreButton.TabIndex = 19;
            this.MoreButton.TabStop = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ButtonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ButtonMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonMin.IconSize = 20;
            this.ButtonMin.Location = new System.Drawing.Point(1020, 0);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.ButtonMin.Size = new System.Drawing.Size(20, 35);
            this.ButtonMin.TabIndex = 15;
            this.ButtonMin.TabStop = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonMax
            // 
            this.ButtonMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ButtonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonMax.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ButtonMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonMax.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.ButtonMax.IconSize = 20;
            this.ButtonMax.Location = new System.Drawing.Point(1040, 0);
            this.ButtonMax.Name = "ButtonMax";
            this.ButtonMax.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.ButtonMax.Size = new System.Drawing.Size(20, 35);
            this.ButtonMax.TabIndex = 14;
            this.ButtonMax.TabStop = false;
            this.ButtonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ButtonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ButtonClose.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.ButtonClose.IconSize = 20;
            this.ButtonClose.Location = new System.Drawing.Point(1060, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.ButtonClose.Size = new System.Drawing.Size(20, 35);
            this.ButtonClose.TabIndex = 12;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1303, 805);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.SidePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1303, 805);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notion Clone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNewNote)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrashButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TitleBox;
        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconPictureBox ButtonMin;
        private FontAwesome.Sharp.IconPictureBox ButtonMax;
        private FontAwesome.Sharp.IconPictureBox ButtonClose;
        private System.Windows.Forms.FlowLayoutPanel NotePanel;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox ButtonNewNote;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox MoreButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox TrashButton;
    }
}

