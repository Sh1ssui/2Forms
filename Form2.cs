using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _2Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.Txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(File.Exists(Data.Path))
            {
                File.WriteAllText(Data.Path, textBox1.Text);
            }
            Data.showForm1();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.Txt = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.showForm1();
            this.Close();
        }
    }
}
