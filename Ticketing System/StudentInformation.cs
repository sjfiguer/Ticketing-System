﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_System;

namespace IT_Ticketing_System__Mock_
{
    public partial class AdminScreen4 : Form
    {
        public AdminScreen4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Close();
            Admin_Home.Show();
        }

        private void Finish_btn_Click(object sender, EventArgs e)//NEEDS MORE CODING NOT DONE
        {
            Form Admin_Home = new Admin_Homepage();
            this.Close();
            Admin_Home.Show();
        }
    }
}
