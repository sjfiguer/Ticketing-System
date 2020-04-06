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
    public partial class QuestionSubmission : Form
    {
        public QuestionSubmission()
        {
            InitializeComponent();
        }

        private void QuestionSubmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fAQDATABASE.FrequentlyAskedQuestions' table. You can move, or remove it, as needed.
            this.frequentlyAskedQuestionsTableAdapter.Fill(this.fAQDATABASE.FrequentlyAskedQuestions);

        }
    }
}
