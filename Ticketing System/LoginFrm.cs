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

namespace CS_Assignment
{
    public partial class FrmLogin : Form
    {
        /////////////////////////

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
            SqlConnection connection = new SqlConnection(@"Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2050;User ID=PROJECTS2050;Password=Data Source=essql1.walton.uark.edu;Initial Catalog=PROJECTS2050;User ID=PROJECTS2050;Password=MV05sts$");
            string Authentication = "SELECT * FROM Login WHERE Username= '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(Authentication, connection);
            DataTable Logintbl = new DataTable();
            SDA.Fill(Logintbl);

            if (Logintbl.Rows.Count <= 2)
            {
                FrmDashboard objFrmDashboard = new FrmDashboard();
                this.Hide();

                objFrmDashboard.Show();
            }
            else
                MessageBox.Show("Authentication not complete.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }





        /////////////

    }
 }

