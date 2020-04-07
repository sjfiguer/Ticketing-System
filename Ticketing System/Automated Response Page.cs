using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class Automated_Response_Page : Form
    {
        public Automated_Response_Page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//LOGOUT
        {
            Form Home = new Home_Page();
            this.Hide();
            Home.Show();
        }

        private void label1_Click(object sender, EventArgs e)//FAQ
        {
            Form FAQ = new FAQ();
            this.Hide();
            FAQ.Show();
        }
    }
}
