﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String password= textBox2.Text;
            
            if (name == "amna" && password == "111"|| name == "affan" && password == "112")
            {
                MessageBox.Show("login");
            }
            else
            {
                MessageBox.Show("error ");
            }




        }
    }
}
