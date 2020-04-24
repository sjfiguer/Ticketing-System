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
        string connectionString = @"Data Source=isys4363.walton.uark.edu; Initial Catalog=PROJECTS2050; User ID= isys4363a; PASSWORD= GohogsUA20";

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
            if (txtpassword.Text != txtconfirmpassword.Text)
                MessageBox.Show("Your Passwords do not match. Please try again.");
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                int answer;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact", txtcontact.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", txtaddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Department", txtdepartment.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@AccountType", txtaccounttype.Text.Trim());

                answer = sqlCmd.ExecuteNonQuery();
                MessageBox.Show("You have been Registered!");
                Clear();
            }
        }
        void Clear()
        {
            txtaccounttype.Text = txtdepartment.Text = txtfirstname.Text = txtfirstname.Text = txtcontact.Text = txtaddress.Text = txtemail.Text = txtpassword.Text
                = txtconfirmpassword.Text = "";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
