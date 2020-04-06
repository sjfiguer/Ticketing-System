namespace Ticketing_System
{
    partial class QuestionSubmission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ticketQueueDatabase = new Ticketing_System.TicketQueueDatabase();
            this.ticketQueueDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAQDATABASE = new Ticketing_System.FAQDATABASE();
            this.frequentlyAskedQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frequentlyAskedQuestionsTableAdapter = new Ticketing_System.FAQDATABASETableAdapters.FrequentlyAskedQuestionsTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAQDATABASE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequentlyAskedQuestionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Please select from the following questions";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.frequentlyAskedQuestionsBindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // ticketQueueDatabase
            // 
            this.ticketQueueDatabase.DataSetName = "TicketQueueDatabase";
            this.ticketQueueDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketQueueDatabaseBindingSource
            // 
            this.ticketQueueDatabaseBindingSource.DataSource = this.ticketQueueDatabase;
            this.ticketQueueDatabaseBindingSource.Position = 0;
            // 
            // fAQDATABASE
            // 
            this.fAQDATABASE.DataSetName = "FAQDATABASE";
            this.fAQDATABASE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frequentlyAskedQuestionsBindingSource
            // 
            this.frequentlyAskedQuestionsBindingSource.DataMember = "FrequentlyAskedQuestions";
            this.frequentlyAskedQuestionsBindingSource.DataSource = this.fAQDATABASE;
            // 
            // frequentlyAskedQuestionsTableAdapter
            // 
            this.frequentlyAskedQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(170, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "If other:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 252);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 79);
            this.textBox2.TabIndex = 29;
            // 
            // QuestionSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 511);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "QuestionSubmission";
            this.Text = "QuestionSubmission";
            this.Load += new System.EventHandler(this.QuestionSubmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAQDATABASE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequentlyAskedQuestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource ticketQueueDatabaseBindingSource;
        private TicketQueueDatabase ticketQueueDatabase;
        private FAQDATABASE fAQDATABASE;
        private System.Windows.Forms.BindingSource frequentlyAskedQuestionsBindingSource;
        private FAQDATABASETableAdapters.FrequentlyAskedQuestionsTableAdapter frequentlyAskedQuestionsTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}