namespace OriginText
{
    partial class form
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
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.savefile = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrap = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.font = new System.Windows.Forms.FontDialog();
            this.load = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArea
            // 
            this.textArea.AcceptsTab = true;
            this.textArea.BackColor = System.Drawing.SystemColors.Window;
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textArea.Location = new System.Drawing.Point(1, 32);
            this.textArea.Margin = new System.Windows.Forms.Padding(0);
            this.textArea.Name = "textArea";
            this.textArea.ShowSelectionMargin = true;
            this.textArea.Size = new System.Drawing.Size(621, 299);
            this.textArea.TabIndex = 2;
            this.textArea.TabStop = false;
            this.textArea.Text = "";
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.formatarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(621, 32);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.savefile});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(62, 28);
            this.file.Text = "文件";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(133, 30);
            this.open.Text = "&打开";
            this.open.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // savefile
            // 
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(133, 30);
            this.savefile.Text = "&保存";
            this.savefile.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.wordwrap});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.formatarToolStripMenuItem.Text = "格式";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.fonteToolStripMenuItem.Text = "字体";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // wordwrap
            // 
            this.wordwrap.Checked = true;
            this.wordwrap.CheckOnClick = true;
            this.wordwrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordwrap.Name = "wordwrap";
            this.wordwrap.Size = new System.Drawing.Size(173, 30);
            this.wordwrap.Text = "自动换行";
            this.wordwrap.Click += new System.EventHandler(this.wordwrapToolStripMenuItem_Click);
            // 
            // font
            // 
            this.font.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.ShowColor = true;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 332);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(700, 250);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notepad";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem savefile;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordwrap;
        private System.Windows.Forms.OpenFileDialog load;
        public System.Windows.Forms.RichTextBox textArea;
    }
}

