using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportcard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1= int.Parse( textBox1.Text);
            int val2= int.Parse( textBox2.Text);
            double percentag = ((double)val2 / val1) * 100;
            char grade;
            if (percentag >= 90)
            {
                grade = "A";

            }
            else if(percentag >= 80)
            {
                grade = "B";
            }
            else if (percentag >= 70)
            {
                grade = "c";
            }
            else
            {
                grade="f"
            }


            MessageBox.Show($"your grade is:{grade}.your percentage is {percentage}");        }
    }
}
