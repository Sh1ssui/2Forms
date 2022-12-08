using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Forms
{
    static class Data
    {
        public static Form1 f1 = new Form1();
        public static string Txt;
        public static string Path;
        public static void showForm1()
        {
            f1.Visible = true;
        }
    }
}
