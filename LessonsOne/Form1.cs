using System;
using System.Windows.Forms;
using System.IO;

namespace LessonsOne
{
    public partial class Form1 : Form
    {
        string file = @"C:\Users\AnatoliyGG\Desktop\1.cmd";
        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (Look(file))
            {
                label1.Text = Say(file, null);
            }
            else
            {
                label1.Text = Say(file, "не");
            }
        }

        bool Look(string line)
        {
            return File.Exists(line) ? true : false;
        }

        string Say(string line, string line2)
        {
            return $"Файл {line} {line2} существует";
        }
        
    }
}
