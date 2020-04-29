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
    public partial class AdminScreen : Form
    {
        /////////////////////////Setting variables
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;       

        ////////////////////
        public AdminScreen()
        {
            InitializeComponent();
            //need to add variables and connection string to load comboboxes with vendor information.
           
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //Form Admin_Home = new Admin_Homepage();
            //this.Hide();
            //Admin_Home.Show();
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

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            //When vender correspondence form loads, we want to have our vendor type and vendor email comboboxes populated

            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");


            sql = "SELECT VendorType, Email  FROM Vendor";
            command = new SqlCommand(sql, connection);
            connection.Open();

            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                TPventypeCmb.Items.Add(datareader[0].ToString());
                TPemailCmb.Items.Add(datareader[1].ToString());
                // Automatically popuates vendor type and email combo box on form load
            }
            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (TPadminIDtxt.Text == "" || MessageBoxTxt.Text == "" || TPemailCmb.Items.ToString() == "" || TPventypeCmb.ToString() == "")
            {
                MessageBox.Show("Error. Fields must be filled before sending message. Please try again.");
            }
            else
            {
                SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
                //grab any data needed
                sql = "INSERT INTO Vendor VALUES (@admID,@Type,@Email,@Issue)";
                connection.Open();
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@admID", TPadminIDtxt.Text);
                command.Parameters.AddWithValue("@Type", TPventypeCmb.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Email", TPemailCmb.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Issue", MessageBoxTxt.Text);

                //Close the Database
                command.Dispose();
                connection.Close();

                //display a message
                MessageBox.Show("Success! Your message has been sent and catalogued in the database. Please allow 3-5 days for reply.");
            }
        }

        private void MessageBoxTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Hide();
            Admin_Home.Show();
        }
    }
}
