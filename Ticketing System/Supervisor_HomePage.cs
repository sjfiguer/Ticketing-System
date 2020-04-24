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
    public partial class Supervisor_HomePage : Form
    {
        public Supervisor_HomePage()
        {
            InitializeComponent();
        }

        private void Supervisor_HomePage_Load(object sender, EventArgs e)
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
            Form Queue = new TicketQueue();
            this.Close();
            Queue.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://app.powerbi.com/groups/me/reports/618df352-8ee7-4173-bb74-0fd98443d5e8/ReportSection?noSignUpCheck=1");
        }
    }
}
