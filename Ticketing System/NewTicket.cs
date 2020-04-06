using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_System
{
    public partial class NewTicket : Form
    {
        public NewTicket()
        {
            InitializeComponent();
        }

        private void NewTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.dataSet2.Ticket);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
