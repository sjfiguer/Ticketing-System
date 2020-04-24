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

namespace Ticketing_System
{
    public partial class Submit_Ticket : Form
    {
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        DataSet DS;


        public Submit_Ticket()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//LOGOFF
        {
            Form Home = new Home_Page();
            this.Close();
            Home.Show();
        }

        private void label1_Click(object sender, EventArgs e)//FAQ
        {
            Form FAQ = new FAQ();
            this.Close();
            FAQ.Show();

        } 

        private void label12_Click(object sender, EventArgs e)//INBOX
        {
            Form Inbox = new Automated_Response_Page();
            this.Close();
            Inbox.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//FAQ HYPERLINK
        {
            Form FAQ = new FAQ();
            this.Close();
            FAQ.Show();
        }

        private void Submit_btn_Click(object sender, EventArgs e)//NEEDS MORE CODE NAVIGATIONAL ONLY NOW
        {
            Form Inbox = new Automated_Response_Page();
            this.Close();
            Inbox.Show();

            try 
            { 
            int answer;

                SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
                connection.Open();
               string sql = null;
                SqlCommand command = new SqlCommand(sql, connection);
                   
            command.Parameters.AddWithValue("@TicketID", TicketIDtxt.Text);
            command.Parameters.AddWithValue("@UserID", UserIDtxt.Text);
            command.Parameters.AddWithValue("@Priority", PriorityCB.AllowDrop);
            command.Parameters.AddWithValue("@Category", CategoryCB.AllowDrop);
            command.Parameters.AddWithValue("@Description", DescribeTxt.Text);

            answer = command.ExecuteNonQuery();

            //close database

            command.Dispose();
            connection.Close();

            //display a message

            MessageBox.Show("Your Ticket has been Submitted");

        }

            catch (Exception ex)

            {

                MessageBox.Show("You have encountered an error" + ex);

            }

    //////////////////////////////////////////
}

private void Submit_Ticket_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            sql = "SELECT DISTINCT Department FROM Users";
            command = new SqlCommand(sql, connection);
            connection.Open();

            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                DepartmentCB.Items.Add(datareader[0].ToString());
                // Automatically popuates combo box on form load
            }

            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();
            // ABOVE FILLS DEPARTMENT CMB

            string sql2 = null;

            sql2 = "SELECT DISTINCT Category FROM Category";
            command = new SqlCommand(sql2, connection);
            connection.Open();

            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                CategoryCB.Items.Add(datareader[0].ToString());
                // Automatically popuates combo box on form load
            }

            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();
            //ABOVE FILLS CATEGORY CB

            string sql3 = null;
            sql3 = "SELECT DISTINCT Priority FROM Ticket";
            command = new SqlCommand(sql3, connection);
            connection.Open();

            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                PriorityCB.Items.Add(datareader[0].ToString());
                // Automatically popuates combo box on form load
            }

            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();
            //ABOVE FILLS PRIORITY CB

        }

        private void DepartmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
