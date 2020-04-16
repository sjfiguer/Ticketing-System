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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            //need to add variables and connection string to load comboboxes with vendor information.
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Hide();
            Admin_Home.Show();
        }

        private void TPadminIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TPadminIDtxt.Clear();
            TPventypeCmb.Items.Clear();
            TPemailCmb.Items.Clear();
            MessageBoxTxt.Clear();
        }

        private void TPventypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
