using System;
using System.Windows.Forms;

namespace LessonsTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{Hello()}, Юзернейм";
        }

        string Hello()
        {
            var time = DateTime.Now.Hour;
            if (time > 3)
            {
                return $"Доброе раннее утро";
            }
            else if (time < 12)
            {
                return $"Доброе  утро";
            }
            else if (time < 15)
            {
                return $"Доброе раннее утро";
            }
            else
            {
                return "Добрый обед";
            }
        }
    }
}
