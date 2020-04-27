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
            connectionstring = "Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20";
            connection = new SqlConnection(connectionstring);
        }

          

        private void Logoff_btn_Click(object sender, EventArgs e)
        {
            Form Home = new Home_Page();
            this.Hide();
            Home.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            TicketQueueDG.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://app.powerbi.com/groups/me/reports/618df352-8ee7-4173-bb74-0fd98443d5e8/ReportSection?noSignUpCheck=1");
        }

        private void TicketQueueDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int answer;
            string reg = TicketQueueDG.CurrentRow.Cells[0].Value.ToString();
            //grab any data needed
            sql = "DELETE FROM Ticket WHERE TicketID = @TicketID";
            connection.Open();
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@TicketID", reg);

            answer = command.ExecuteNonQuery();
            //Close the database
            command.Dispose();
            connection.Close();

            //display a message
            MessageBox.Show("You deleted " + answer + " row");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=isys4363.walton.uark.edu;Initial Catalog=TicketingSystem;User ID=isys4363a;Password=GohogsUA20");

            connection.Open();
            SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM Ticket", connection);
            DataTable dtbl = new DataTable();
            sql.Fill(dtbl);

            TicketQueueDG.DataSource = dtbl;
        }
    }
}
