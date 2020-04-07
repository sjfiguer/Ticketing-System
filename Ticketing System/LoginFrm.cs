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
           


        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //////////////
            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
            string Authentication = "SELECT * FROM Login WHERE UserID= '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'"; //Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2050;User ID=PROJECTS2050;Password=MV05sts$
            SqlDataAdapter SDA = new SqlDataAdapter(Authentication, connection);
            DataTable Logintbl = new DataTable();
            SDA.Fill(Logintbl);
            string Admin_Type =  ("SELECT UserType FROM Login WHERE UserType = 'Admin'");
            //Admin_Type.Fill(DS);
            
            

            if (Admin_Type != true)//ADMINS
            {
                Form Admin = new TicketInformation();
                MessageBox.Show("Login Successful");
                this.Hide();
                Admin.Show();

                
            }
            else {
            if (Logintbl.Rows.Count == 3)//SUPERVISOR
                {
                    Form Supervisor = new TicketQueue();
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    Supervisor.Show();
                }
                else
                {
                    if(Logintbl.Rows.Count >= 4)//USERs
                    {
                        Form User = new Submit_Ticket();
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        User.Show();
                    }
                    else
                        MessageBox.Show("Authentication not complete.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        /////////////

    }
 }

