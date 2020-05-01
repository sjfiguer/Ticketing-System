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
        DataSet ds;


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
            //this.ticketTableAdapter.Fill(this.ticketQueueDatabase.Ticket);
            UserNameInfolbl.Text = Submit_Ticket.UserName;//DONOTREMOVEIF YOU WANT THE SQL TO WORK

            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
            connection.Open();
            sql = "SELECT * FROM Ticket WHERE Username = '" + UserNameInfolbl.Text + "'";
            var dataadapter = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //datareader.Close();
            //command.Dispose();
            connection.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form Logout = new Home_Page();
            this.Hide();
            Logout.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form FAQ2 = new FAQ();
            this.Hide();
            FAQ2.Show();
        }
    }
}
