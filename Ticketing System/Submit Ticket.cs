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
            LoginIDlbl.Text = FrmLogin.LoginIDInfo2;
        }
        private void Submit_Ticket_Load(object sender, EventArgs e)
        {
            LoginIDlbl.Text = FrmLogin.LoginIDInfo2;
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

            string sql3 = "SELECT DISTINCT Priority FROM Ticket";
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

            sql = "SELECT CONVERT(varchar, getdate(), 1) ";
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                Datetxt.Text = datareader[0].ToString(); //The 0 indicates the first attribute in my select statement but it's n-1

            }
            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();


            sql = "SELECT TOP 1 TicketID FROM Ticket ORDER BY TicketID desc";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                int counter = Convert.ToInt32(datareader[0].ToString());
                counter = counter + 1;
                TicketIDtxt.Text = counter.ToString();
            }


            //Closes the Database
            datareader.Close();
            command.Dispose();
            connection.Close();

            sql = "SELECT REPLACE(FirstName, ' ', '') + ' ' + LastName FROM Users Where LoginID ='" + LoginIDlbl.Text.ToString() + "'";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                LastNametxt.Text = datareader[0].ToString();

            }

            datareader.Close();
            command.Dispose();
            connection.Close();

            sql = "select Email FROM Users where LoginID ='" + LoginIDlbl.Text.ToString() + "'";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                Emailtxt.Text = datareader[0].ToString();

            }

            datareader.Close();
            command.Dispose();
            connection.Close();

            sql = "select Department FROM Users where LoginID ='" + LoginIDlbl.Text.ToString() + "'";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                DepartmentCB.Text = datareader[0].ToString();

            }

            datareader.Close();
            command.Dispose();
            connection.Close();

            sql = "select UserID FROM Users where LoginID ='" + LoginIDlbl.Text.ToString() + "'";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                UserIDtxt.Text = datareader[0].ToString();

            }

            datareader.Close();
            command.Dispose();
            connection.Close();


        }

        private void DepartmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            sql = "SELECT CatID from Category where Category = '" + CategoryCB.Text.ToString() + "'";// check in database
            connection.Open();
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                int counter = Convert.ToInt32(datareader[0].ToString());

                CATIDtxt.Text = counter.ToString(); ;
            }
            datareader.Close();
            command.Dispose();
            connection.Close();




            //sql = "SELECT CatID from Category where Category = '" + CategoryCB.Text.ToString() + "'";
            //connection.Open();

            //SqlCommand command = new SqlCommand(sql, connection);
            //datareader = command.ExecuteReader();
            //while (datareader.Read())
            //{
            //    CATIDtxt.Text = datareader[0].ToString(); 

            //}
            ////Closes the Database
            //datareader.Close();
            //command.Dispose();
            //connection.Close();
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

            //try
            //{
                connectionstring = "Data Source = isys4363.walton.uark.edu; Initial Catalog = TicketingSystem; User ID = isys4363a; Password = GohogsUA20";
                connection = new SqlConnection(connectionstring);
                int answer;
                string sql2 = null;
                sql = "SELECT CatID from Category where Category = '" + CategoryCB.ToString() + "'";

                sql2 = "INSERT INTO Ticket VALUES (@UserID, @Status, @AssignedTo,  @Priority,  @DateIssued,  @DateR, @CatID, @Category, @Description, @AdminID) ";
                connection.Open();
            string UID2 = "";
            string CatID2 = "";

            command = new SqlCommand(sql2, connection);

            command.Parameters.AddWithValue("@UserID", UID2);
            command.Parameters.AddWithValue("@Status", "Active"); //
                command.Parameters.AddWithValue("@AssignedTo", "");
                command.Parameters.AddWithValue("@Priority", PriorityCB.SelectedItem.ToString());
                command.Parameters.AddWithValue("@DateIssued", Datetxt.Text);
                command.Parameters.AddWithValue("@DateR", "Ongoing");
            command.Parameters.AddWithValue("@CatID", CatID2);
            command.Parameters.AddWithValue("@Category", CategoryCB.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Description", DescribeTxt.Text);
                command.Parameters.AddWithValue("@AdminID", "");
               

            answer = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                

            connection = new SqlConnection(connectionstring);
            sql = "UPDATE Ticket SET UserID = @UserID ,  @CATID";
            string UID = UserIDtxt.Text.ToString();

            string CATID = CATIDtxt.Text.ToString();

            command.Parameters.AddWithValue("@UserID", UID);
            command.Parameters.AddWithValue("@CATID", CATID);

            answer = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();


            MessageBox.Show("Your Ticket has been Submitted and added to our que. Your ticket will be resolved shortly.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred while inserting data " + ex);
            //}



            //    int answer;
            //        string sql2 = null;
            //        SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
            //        SqlCommand command = new SqlCommand(sql, connection);
            //        sql2 = "SELECT CatID from Category where Category = '" + CategoryCB.Text.ToString() + "'";




            //        string UID = UserIDtxt.ToString();
            //        string Status = "Active";
            //        string AssignedTo = "";
            //        string PR = PriorityCB.ToString();
            //        string DATEI = Datetxt.Text.ToString();
            //        string DATER = "Ongoing";
            //        string CATID = CATIDtxt.ToString();
            //        string CAT = CategoryCB.ToString();
            //        string Description = DescribeTxt.Text.ToString();
            //        string AdminID = "";
            //        Convert.ToInt32(CAT);
            //        sql = "INSERT INTO Ticket VALUES ( @UserID,  @Status, @AssignedTo,  @Priority,  @DateIssued,  @DateR,  @CATID, @Category, @Description, @AdminID)";
            //        connection.Open();

            //        SqlCommand command2 = new SqlCommand(sql2, connection);

            //       // command.Parameters.AddWithValue("@TicketID", TicketIDtxt.Text);
            //    command.Parameters.AddWithValue("@UserID", UserIDtxt.Text);
            //        command.Parameters.AddWithValue("@Status", Status); //
            //        command.Parameters.AddWithValue("@AssignedTo", AssignedTo);
            //        command.Parameters.AddWithValue("@Priority", PR);
            //        command.Parameters.AddWithValue("@DateIssued",DATEI);
            //        command.Parameters.AddWithValue("@DateR", DATER);
            //        command.Parameters.AddWithValue("@CATID", CATID);
            //        command.Parameters.AddWithValue("@Category", CAT);
            //        command.Parameters.AddWithValue("@Description", Description);
            //        command.Parameters.AddWithValue("@AdminID", AdminID);

            //        answer = command.ExecuteNonQuery();

            //    //close database

            //    command.Dispose();
            //    connection.Close();

            //    //display a message

            //    MessageBox.Show("Your Ticket has been Submitted");

            //}

            //    catch (Exception ex)

            //    {

            //        MessageBox.Show("You have encountered an error" + ex);

            //    }

            //////////////////////////////////////////
        }


    }
}
