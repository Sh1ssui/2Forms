using System;
using System.Windows.Forms;
using System.IO;

namespace _2Forms
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            if(Data.Txt!="")
            {
                textBox1.Text = Data.Txt;
            }
            textBox1.ScrollBars=ScrollBars.Vertical;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.Txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Data.Path=file.FileName;
                textBox1.Text = File.ReadAllText(file.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button2.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Txt = textBox1.Text;
            f2.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            //this.Hide();
        }
    }
}
