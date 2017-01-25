using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OriginText
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)  //Save
        {
            save.Filter = "txt files (*.txt)|*.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            { textArea.SaveFile(save.FileName, RichTextBoxStreamType.PlainText); }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)   //open
        {
            load.Filter = "txt files (*.txt)|*.txt";
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                System.IO.StreamReader file = new System.IO.StreamReader(@load.FileName);
                textArea.Text = file.ReadToEnd();}
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)           //font
        {
            font.ShowDialog();
            textArea.Font = font.Font;
            textArea.ForeColor = font.Color;
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)   //WordWrap
        {
            if (wordwrap.Checked == true)
            {  textArea.WordWrap = true; }
            else 
            {  textArea.WordWrap = false; }
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
