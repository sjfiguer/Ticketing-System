using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Assignment;
using System.Data.SqlClient;

namespace Ticketing_System
{
    public partial class TicketQueue : Form
    {
        string connectionstring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        DataSet DS;


        public TicketQueue()
        {
            InitializeComponent();
        }

        private void TicketQueue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketQueueDatabase.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.ticketQueueDatabase.Ticket);
            
        }

          

        private void Logoff_btn_Click(object sender, EventArgs e)
        {
            Form Home = new Home_Page();
            this.Hide();
            Home.Show();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            int answer;
            string sql2 = null;


            sql = "SELECT * FROM Ticket";
            var dataadapter = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            TicketQueueDG.DataSource = ds.Tables[0];
            TicketQueueDG.Update();
            TicketQueueDG.Refresh(); // REFRESHES DGV


            //try
            //{

            //    string TID = TicketQueueDG.CurrentRow.Cells[0].Value.ToString();
            //    string UID = TicketQueueDG.CurrentRow.Cells[1].Value.ToString();
            //    string BLCK = TicketQueueDG.CurrentRow.Cells[2].Value.ToString();
            //    string TITLE = TicketQueueDG.CurrentRow.Cells[3].Value.ToString();
            //    string STATUS = "Refreah";
            //    string RUSER = TicketQueueDG.CurrentRow.Cells[5].Value.ToString();
            //    string AssignedTo = TicketQueueDG.CurrentRow.Cells[6].Value.ToString();
            //    string PR = TicketQueueDG.CurrentRow.Cells[7].Value.ToString();
            //    string DATEI = TicketQueueDG.CurrentRow.Cells[8].Value.ToString();
            //    string CATID = TicketQueueDG.CurrentRow.Cells[10].Value.ToString();
            //    string CAT = TicketQueueDG.CurrentRow.Cells[11].Value.ToString();

            //    sql = "Refresh Ticket SET TicketID = @TicketID, UserID = @UserID, Blackout = @Blackout, Title = @Title, Status = @Status, RequestUser = @RUser, AssignedTo = @AssigneTo, Priority = @Priority, DateIssued = @DateI, DateResolved = @DateR, CatID = @CatID, Category = @CAT";

            //    connection.Open();
            //    command = new SqlCommand(sql, connection);

            //    command.Parameters.AddWithValue("@TicketID", TID);
            //    command.Parameters.AddWithValue("@UserID", UID);
            //    command.Parameters.AddWithValue("@Blackout", BLCK);
            //    command.Parameters.AddWithValue("@Title", TITLE);
            //    command.Parameters.AddWithValue("@Status", STATUS);
            //    command.Parameters.AddWithValue("@RUser", RUSER);
            //    command.Parameters.AddWithValue("@AssigneTo", AssignedTo);
            //    command.Parameters.AddWithValue("@Priority", PR);
            //    command.Parameters.AddWithValue("@DateI", DATEI);
            //    command.Parameters.AddWithValue("@DateR", sql2);
            //    command.Parameters.AddWithValue("@CatID", CATID);
            //    command.Parameters.AddWithValue("@CAT", CAT);

            //    answer = command.ExecuteNonQuery();

            //    command.Dispose();
            //    connection.Close();

            //    MessageBox.Show("Resolved " + answer);

            //}
            //catch (Exception ex)// calls the error into message box
            //{
            //    MessageBox.Show("Form Error" + ex);
            //}

        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://app.powerbi.com/groups/me/reports/618df352-8ee7-4173-bb74-0fd98443d5e8/ReportSection?noSignUpCheck=1");
        }
    }
}
