using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticketing_System;
using System.Data.SqlClient;


namespace IT_Ticketing_System__Mock_
{
    public partial class RegisterForm : Form
    {
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Hide();
            Admin_Home.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////
            int answer;
            //grab any data needed
            sql = "INSERT INTO Login VALUES (@UserID,@Password,@UserType,@First_Name,@Last_Name,@Contact,@Address,@Email)";
            connection.Open();
            command = new SqlCommand(sql, connection);

            //parameters are designed to enhance a sql statement from objects in the code
            command.Parameters.AddWithValue("@UserID", txtstudentid.Text);
            command.Parameters.AddWithValue("@Password", txtpassword.Text);
            command.Parameters.AddWithValue("@UserType", AccountTypecb.SelectedItem.ToString());
            command.Parameters.AddWithValue("@First_Name", txtfirstname.Text);
            command.Parameters.AddWithValue("@Last_Name", txtlastname.Text);
            command.Parameters.AddWithValue("@Contact", txtcontact.Text);
            command.Parameters.AddWithValue("@Address", txtaddress.Text);
            command.Parameters.AddWithValue("@Email", txtemail.Text);

            answer = command.ExecuteNonQuery();
            //Close the database
            command.Dispose();
            connection.Close();

            //display a message
            MessageBox.Show("You added " + answer + " row");
            //////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            connectionstring = "Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20";
            connection = new SqlConnection(connectionstring);
            sql = "SELECT LoginID FROM Login";
            connection.Open();
            command = new SqlCommand(sql, connection);
            command.Dispose();
            connection.Close();

            sql = "SELECT DISTINCT UserType FROM Login";
            command = new SqlCommand(sql, connection);
            connection.Open();

            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                AccountTypecb.Items.Add(datareader[0].ToString());
                // Automatically popuates combo box on form load
            }

            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();
        }

        private void txtaccounttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Close();
            Admin_Home.Show();

        }
    }
}

