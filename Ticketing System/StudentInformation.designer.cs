namespace IT_Ticketing_System__Mock_
{
    partial class AdminScreen4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed_Requests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pending_Requests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First_Name,
            this.Last_Name,
            this.Email,
            this.Class_Info,
            this.Completed_Requests,
            this.Pending_Requests});
            this.dataGridView1.Location = new System.Drawing.Point(97, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(956, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 616);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 616);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(865, 616);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Finish";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Information";
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.MinimumWidth = 10;
            this.First_Name.Name = "First_Name";
            this.First_Name.Width = 200;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MinimumWidth = 10;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 10;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Class_Info
            // 
            this.Class_Info.HeaderText = "Class Information";
            this.Class_Info.MinimumWidth = 10;
            this.Class_Info.Name = "Class_Info";
            this.Class_Info.Width = 200;
            // 
            // Completed_Requests
            // 
            this.Completed_Requests.HeaderText = "Completed Requests";
            this.Completed_Requests.MinimumWidth = 10;
            this.Completed_Requests.Name = "Completed_Requests";
            this.Completed_Requests.Width = 200;
            // 
            // Pending_Requests
            // 
            this.Pending_Requests.HeaderText = "Pending Requests";
            this.Pending_Requests.MinimumWidth = 10;
            this.Pending_Requests.Name = "Pending_Requests";
            this.Pending_Requests.Width = 200;
            // 
            // AdminScreen4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminScreen4";
            this.Text = "AdminScreen4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed_Requests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pending_Requests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

