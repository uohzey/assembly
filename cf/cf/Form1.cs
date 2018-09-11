using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog newDLG = new OpenFileDialog();
            if(newDLG.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(newDLG.FileName,Encoding.GetEncoding("GB2312")))
                {
                    string text = sr.ReadToEnd();
                    TextBox.Text =text;
                }
            }
        }
        private void 词法编辑WToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            string Fname;
            SaveFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            SaveFileDialog1.Title = "保存文件 ";
            SaveFileDialog1.RestoreDirectory = true;
            SaveFileDialog1.ShowDialog();
            Fname = SaveFileDialog1.FileName;
            if (Fname != "")
                this.TextBox.SaveFile(Fname, RichTextBoxStreamType.PlainText);
        }

       
    }
}
