using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            label4.Text = "Результат:" + yesNo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;
            label1.Text = "Результат:" + number.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;
            count--;
            label2.Text = "Результат:" + count.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "Hello";
            result += " again " + result;
            label3.Text = "Результат:" + result.ToString();
        }
    }
}
