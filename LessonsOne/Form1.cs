using System;
using System.Windows.Forms;
using System.IO;

namespace LessonsOne
{
    public partial class Form1 : Form
    {
        string File1 = @"C:\Users\AnatoliyGG\Desktop\1.cmd";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(File1))
            {
                Method("Файл есть");
            }
            else
            {
                Method("Файла нет");
            }
        }
        
        void Method(string line)
        {
            MessageBox.Show(line, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
