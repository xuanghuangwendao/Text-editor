using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textEditor
{
    public partial class FormFIndReplace : Form
    {
        Form1 MainForm;
        int type;
        public FormFIndReplace(Form1 form1, int type)
        {
            InitializeComponent();
            MainForm = form1;
            this.type = type;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (type == 1)
            {
                this.label2.Hide();
                this.textBox2.Hide();
                this.button2.Hide();
                this.Text = "查找";
            }
            else
            {
                this.Text = "替换";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("查找字符串不能为空", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MainForm.FindRichTextBoxString(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0)
            {
                MessageBox.Show("查找字符串不能为空", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MainForm.ReplaceRichTextBoxString(textBox2.Text);
            }
        }
    }
}
