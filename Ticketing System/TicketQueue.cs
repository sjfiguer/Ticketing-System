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

namespace Ticketing_System
{
    public partial class TicketQueue : Form
    {
        public TicketQueue()
        {
            InitializeComponent();
        }

        private void TicketQueue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketQueueDatabase.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.ticketQueueDatabase.Ticket);

        }

        private void Tools_btn_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Close();
            Admin_Home.Show();
        }

        private void Logoff_btn_Click(object sender, EventArgs e)
        {
            Form Home = new Home_Page();
            this.Hide();
            Home.Show();
        }
    }
}
