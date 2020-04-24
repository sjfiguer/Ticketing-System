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
    public partial class TicketInformation : Form
    {
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        DataSet DS;

        public TicketInformation()
        {
            InitializeComponent();
            
        }

        private void TicketInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketingSystemDataSet2.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter1.Fill(this.ticketingSystemDataSet2.Ticket);
            // TODO: This line of code loads data into the 'ticketingSystemDataSet1.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.ticketingSystemDataSet1.Ticket);
            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");
            try
            {
                sql = "SELECT * FROM Ticket";
                var dataadapter = new SqlDataAdapter(sql, connection);
                var ds = new DataSet();
                dataadapter.Fill(ds);
                Admin_Queue_DGV.DataSource = ds.Tables[0];

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


            }
            catch (Exception ex)// calls the error into message box
            {
                MessageBox.Show("Form Error" + ex);
            }

        }

        private void Tools_btn_Click(object sender, EventArgs e)
        {
            Form Admin_Home = new Admin_Homepage();
            this.Close();
            Admin_Home.Show();

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Form Home = new Home_Page();
            this.Hide();
            Home.Show();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int answer;
           SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            try
            {

                string TID = Admin_Queue_DGV.CurrentRow.Cells[0].Value.ToString();

                //string TID = Admin_Queue_DGV.CurrentRow.Cells[0].Value.ToString();
                //string UID = Admin_Queue_DGV.CurrentRow.Cells[1].Value.ToString();
                string STATUS = Admin_Queue_DGV.CurrentRow.Cells[2].Value.ToString();
                string AssignedTo = Admin_Queue_DGV.CurrentRow.Cells[3].Value.ToString();
                string PR = Admin_Queue_DGV.CurrentRow.Cells[4].Value.ToString();
                string DATEI = Admin_Queue_DGV.CurrentRow.Cells[5].Value.ToString();
                string DATER = Admin_Queue_DGV.CurrentRow.Cells[6].Value.ToString();
                string CATID = Admin_Queue_DGV.CurrentRow.Cells[7].Value.ToString();
                string CAT = Admin_Queue_DGV.CurrentRow.Cells[8].Value.ToString();
                string DESCRIPTION = TCK_Info_RTB.Text;
                string AID = Admin_Queue_DGV.CurrentRow.Cells[10].Value.ToString();


                sql = "UPDATE Ticket SET Priority = @Priority, DateResolved = @DateR, Description = @Description WHERE TicketID = @TID ";

                connection.Open();
                command = new SqlCommand(sql, connection);


                command.Parameters.AddWithValue("@TID", TID);
                //command.Parameters.AddWithValue("@UserID", UID);TicketID = @TicketID, UserID = @UserID,
                //command.Parameters.AddWithValue("@Status", STATUS);
                //command.Parameters.AddWithValue("@AssigneTo", AssignedTo); Status = @Status, AssignedTo = @AssigneTo,
                command.Parameters.AddWithValue("@Priority", PR);
                //command.Parameters.AddWithValue("@DateI", DATEI); , DateIssued = @DateI DateResolved = @DateR, CatID = @CatID, Category = @CAT, 
                command.Parameters.AddWithValue("@DateR", DATER);
                //command.Parameters.AddWithValue("@CatID", CATID);
                //command.Parameters.AddWithValue("@CAT", CAT);
                command.Parameters.AddWithValue("@Description", DESCRIPTION);
                //command.Parameters.AddWithValue("@AID", AID); , AdminID = @AID


                answer = command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                MessageBox.Show("Updated " + answer);

                sql = "SELECT * FROM Ticket";
                var dataadapter = new SqlDataAdapter(sql, connection);
                var ds = new DataSet();
                dataadapter.Fill(ds);
                Admin_Queue_DGV.DataSource = ds.Tables[0];
                Admin_Queue_DGV.Update();
                Admin_Queue_DGV.Refresh(); // REFRESHES DGV

            }
            catch (Exception ex)// calls the error into message box
            {
                MessageBox.Show("Form Error" + ex);
            }

        }

        private void Resolved_btn_Click(object sender, EventArgs e)
        {
            int answer;
            string sql2 = null;
            SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            //try
            //{

                string TID = Admin_Queue_DGV.CurrentRow.Cells[0].Value.ToString();
                //string UID = Admin_Queue_DGV.CurrentRow.Cells[1].Value.ToString();
                string STATUS = "Resolved";
            //string AssignedTo = Admin_Queue_DGV.CurrentRow.Cells[3].Value.ToString();
            //string PR = Admin_Queue_DGV.CurrentRow.Cells[4].Value.ToString();
            //string DATEI = Admin_Queue_DGV.CurrentRow.Cells[5].Value.ToString();
            //string CATID = Admin_Queue_DGV.CurrentRow.Cells[7].Value.ToString();
            //string CAT = Admin_Queue_DGV.CurrentRow.Cells[8].Value.ToString();
            //string DESCRIPTION = Admin_Queue_DGV.CurrentRow.Cells[9].Value.ToString();
            //string AID = Admin_Queue_DGV.CurrentRow.Cells[10].Value.ToString();
            string DATER = Datetxt.Text.ToString();





                sql = "UPDATE Ticket SET  Status = @Status,  DateResolved = @DateR WHERE TicketID = @TicketID ";
                 
            connection.Open();
                command = new SqlCommand(sql, connection);

               command.Parameters.AddWithValue("@TicketID", TID);
                //command.Parameters.AddWithValue("@UserID", UID);UserID = @UserID, TicketID = @TicketID,
                command.Parameters.AddWithValue("@Status", STATUS);
            //command.Parameters.AddWithValue("@AssigneTo", AssignedTo); AssignedTo = @AssigneTo, Priority = @Priority, DateIssued = @DateI,
            //command.Parameters.AddWithValue("@Priority", PR);
            //command.Parameters.AddWithValue("@DateI", DATEI);
            command.Parameters.AddWithValue("@DateR", DATER); ; 
            //command.Parameters.AddWithValue("@CatID", CATID); , CatID = @CatID, Category = @CAT, Description = @Description, AdminID = @AID
            //command.Parameters.AddWithValue("@CAT", CAT);
            //command.Parameters.AddWithValue("@Description", DESCRIPTION);
            //command.Parameters.AddWithValue("@AID", AID);
            answer = command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                MessageBox.Show("Resolved " + answer);

            sql = "SELECT * FROM Ticket";
            var dataadapter = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            Admin_Queue_DGV.DataSource = ds.Tables[0];
            Admin_Queue_DGV.Update();
            Admin_Queue_DGV.Refresh();


            //}
            //catch (Exception ex)// calls the error into message box
            //{
            //    MessageBox.Show("Form Error" + ex);
            //}

        }

        private void Admin_Queue_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TCK_Info_RTB.Text = Admin_Queue_DGV.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
