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
            // TODO: This line of code loads data into the 'ticketingSystemDataSet1.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.ticketingSystemDataSet1.Ticket);
            SqlConnection connection = new SqlConnection(@"Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            sql = "SELECT * FROM Ticket";
            var dataadapter = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            dataadapter.Fill(ds);
            Admin_Queue_DGV.DataSource = ds.Tables[0];

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

        }

        private void Resolved_btn_Click(object sender, EventArgs e)
        {
            int answer;
            string sql2 = null;

            string TID = Admin_Queue_DGV.CurrentRow.Cells[0].Value.ToString();
            string UID = Admin_Queue_DGV.CurrentRow.Cells[1].Value.ToString();
            string BLCK = Admin_Queue_DGV.CurrentRow.Cells[2].Value.ToString();
            string TITLE = Admin_Queue_DGV.CurrentRow.Cells[3].Value.ToString();
            string STATUS = "Resolved";//DONT NEED
            string RUSER = Admin_Queue_DGV.CurrentRow.Cells[5].Value.ToString();
            string AssignedTo = Admin_Queue_DGV.CurrentRow.Cells[6].Value.ToString();
            string PR = Admin_Queue_DGV.CurrentRow.Cells[7].Value.ToString();
            string DATEI = Admin_Queue_DGV.CurrentRow.Cells[8].Value.ToString();
            string DATER = Admin_Queue_DGV.CurrentRow.Cells[9].Value.ToString();//DONT NEED
            string CATID = Admin_Queue_DGV.CurrentRow.Cells[10].Value.ToString();
            string CAT = Admin_Queue_DGV.CurrentRow.Cells[11].Value.ToString();

            sql = "UPDATE Ticket SET TicketID = @TicketID, UserID = @UserID, Blackout = @Blackout, Title = @Title, Status = @Status, RequestUser = @RUser, AssignedTo = @AssigneTo, Priority = @Priority, DateIssued = @DateI, DateResolved = @DateR, CatID = @CatID, Category = @CAT";
            sql2 = "SELECT CURRENT_TIMESTAMP";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@TicketID", TID);
            command.Parameters.AddWithValue("@UserID", UID);
            command.Parameters.AddWithValue("@Blackout", BLCK );
            command.Parameters.AddWithValue("@Title", TITLE);
            command.Parameters.AddWithValue("@Status", STATUS);
            command.Parameters.AddWithValue("@RUser", RUSER);
            command.Parameters.AddWithValue("@AssigneTo", AssignedTo);
            command.Parameters.AddWithValue("@Priority", PR );
            command.Parameters.AddWithValue("@DateI", DATEI);
            command.Parameters.AddWithValue("@DateR", sql2);
            command.Parameters.AddWithValue("@CatID", CATID);
            command.Parameters.AddWithValue("@CAT", CAT);

            answer = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

        }
    }
}
