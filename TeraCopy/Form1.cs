using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeraCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sourceFile = textBox1.Text;
            String destFile = textBox2.Text + "//" + openFileDialog1.SafeFileName.ToString();
            System.IO.File.Copy(sourceFile, destFile, true);
            label3.Visible = true;
            label3.Text="File Copied";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "SelectFile";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = this.folderBrowserDialog1.SelectedPath;
            }

        }
    }
}
