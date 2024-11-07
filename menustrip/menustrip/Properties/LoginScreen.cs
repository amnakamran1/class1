using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip.Properties
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username== "Amna" && password == "123" || username == "Affan" && password == "124")
            {
               // MessageBox.Show("login");
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
