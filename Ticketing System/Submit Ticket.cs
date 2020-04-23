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

            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu; Initial Catalog=PROJECTS2050; User ID= isys4363a; PASSWORD= GohogsUA20");
            connection.Open();
                string sql = null;
                SqlCommand command = new SqlCommand(sql, connection);
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

        }
    }
}
