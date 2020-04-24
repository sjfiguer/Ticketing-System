using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Assignment;
using IT_Ticketing_System__Mock_;

namespace Ticketing_System
{
    public partial class Admin_Homepage : Form
    {
        public Admin_Homepage()
        {
            InitializeComponent();
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {

        }

        private void Third_Party_btn_Click(object sender, EventArgs e)
        {
            Form Third_Party = new AdminScreen();
            this.Hide();
            Third_Party.Show();
        }

        private void Create_Account_btn_Click(object sender, EventArgs e)
        {
            Form Create_Account = new RegisterForm();
            this.Hide();
            Create_Account.Show();
        }

        private void Class_Erollment_btn_Click(object sender, EventArgs e)
        {
            Form Student_Info = new AdminScreen4();
            this.Hide();
            Student_Info.Show();
        }

        private void Admin_Home_btn_Click(object sender, EventArgs e)
        {
            Form Queue = new TicketInformation();
            this.Close();
            Queue.Show();
        }
    }
}
