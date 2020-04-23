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
using CS_Assignment;
using Ticketing_System;

namespace CS_Assignment
{
    public partial class FrmLogin : Form
    {
        /////////////////////////Testing Github
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        DataSet DS;
        ////////////////////

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //Ends the program
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketingSystemDataSet.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.ticketingSystemDataSet.Login);

            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            
            sql = "SELECT DISTINCT UserType FROM Login";
            command = new SqlCommand(sql, connection);
            connection.Open();
            
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                //loading the items into the combo box based on the database
                User_Type_cmbox.Items.Add(datareader[0].ToString());
                // Automatically popuates combo box on form load
            }
            
            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();



        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //////////////
            try
            {
                connectionstring = (@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
                var cmd1 = "SELECT * FROM Login WHERE UserID= '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "' and UserType = '" + User_Type_cmbox.SelectedItem.ToString() + "'"; //Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2050;User ID=PROJECTS2050;Password=MV05sts$
                                                                                                                                                                                                                    //SqlDataAdapter SDA = new SqlDataAdapter(Authentication, connection);
            }
            catch { MessageBox.Show("Please fill out all fields"); }                                                                                                                                                                                                   //DataTable Logintbl = new DataTable();
                                                                                                                                                                                                                   //SDA.Fill(Logintbl);


                connectionstring = (@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
                var cmd = "SELECT * FROM Login WHERE UserID= '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "' and UserType = '" + User_Type_cmbox.SelectedItem.ToString() + "'";

                connection = new SqlConnection(connectionstring);
                connection.Open();

                var dataadapter = new SqlDataAdapter(cmd, connection);
                var ds = new DataSet();
                dataadapter.Fill(ds);
                connection.Close();


                DataTable dt = new DataTable();




                if ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0) && (txtUsername.Text != "") && (txtPassword.Text != "") && (User_Type_cmbox.SelectedIndex > -1))
                {
                    Form Admin = new TicketInformation();
                    Form Supervisor = new TicketQueue();
                    Form User = new Submit_Ticket();
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    if (User_Type_cmbox.SelectedIndex == 0)//Admin
                    {
                        Admin.Show();
                    }
                    else
                    {
                        if (User_Type_cmbox.SelectedIndex == 1)//STAFF
                        {
                            User.Show();
                        }
                        else
                        {
                            if (User_Type_cmbox.SelectedIndex == 2)//STUDENT
                            {
                                User.Show();
                            }
                            else
                            {
                                if (User_Type_cmbox.SelectedIndex == 3)//Supervisor
                                {
                                    Supervisor.Show();
                                }
                                else
                                    MessageBox.Show("Please Choose Status");

                            }
                        }
                    }


                }
                else
                    MessageBox.Show("Authentication not complete.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
           







            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }





        /////////////

    }
 }

