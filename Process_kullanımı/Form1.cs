using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Process_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
