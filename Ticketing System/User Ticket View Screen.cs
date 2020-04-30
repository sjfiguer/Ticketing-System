using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using CS_Assignment;

namespace Ticketing_System
{
    public partial class User_Ticket_View_Screen : Form
    {

        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        DataSet DS;


        public User_Ticket_View_Screen()
        {
            InitializeComponent();
            UserNameInfolbl.Text = Submit_Ticket.UserName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void User_Ticket_View_Screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketQueueDatabase.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.ticketQueueDatabase.Ticket);
            UserNameInfolbl.Text = Submit_Ticket.UserName;//DONOTREMOVEIF YOU WANT THE SQL TO WORK

            //sql = "SELECT * FROM Ticket WHERE Username = '" + UserNameInfolbl.Text + "'";
        }
    }
}
