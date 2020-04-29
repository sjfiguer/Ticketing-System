namespace Ticketing_System
{
    partial class TicketQueue
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
            this.TicketQueueDG = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketQueueDatabase = new Ticketing_System.TicketQueueDatabase();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ticketTableAdapter = new Ticketing_System.TicketQueueDatabaseTableAdapters.TicketTableAdapter();
            this.Logoff_btn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketQueueDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Queue";
            // 
            // TicketQueueDG
            // 
            this.TicketQueueDG.AllowUserToOrderColumns = true;
            this.TicketQueueDG.AutoGenerateColumns = false;
            this.TicketQueueDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketQueueDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.assignedToDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.dateResolvedDataGridViewTextBoxColumn,
            this.CatID,
            this.Category,
            this.Description});
            this.TicketQueueDG.DataSource = this.ticketBindingSource;
            this.TicketQueueDG.Location = new System.Drawing.Point(12, 79);
            this.TicketQueueDG.Name = "TicketQueueDG";
            this.TicketQueueDG.RowHeadersWidth = 51;
            this.TicketQueueDG.Size = new System.Drawing.Size(1071, 290);
            this.TicketQueueDG.TabIndex = 1;
            this.TicketQueueDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketQueueDG_CellContentClick);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignedToDataGridViewTextBoxColumn
            // 
            this.assignedToDataGridViewTextBoxColumn.DataPropertyName = "AssignedTo";
            this.assignedToDataGridViewTextBoxColumn.HeaderText = "AssignedTo";
            this.assignedToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignedToDataGridViewTextBoxColumn.Name = "assignedToDataGridViewTextBoxColumn";
            this.assignedToDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateResolvedDataGridViewTextBoxColumn
            // 
            this.dateResolvedDataGridViewTextBoxColumn.DataPropertyName = "DateResolved";
            this.dateResolvedDataGridViewTextBoxColumn.HeaderText = "DateResolved";
            this.dateResolvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateResolvedDataGridViewTextBoxColumn.Name = "dateResolvedDataGridViewTextBoxColumn";
            this.dateResolvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // CatID
            // 
            this.CatID.DataPropertyName = "CatID";
            this.CatID.HeaderText = "CatID";
            this.CatID.MinimumWidth = 6;
            this.CatID.Name = "CatID";
            this.CatID.ReadOnly = true;
            this.CatID.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.ticketQueueDatabase;
            // 
            // ticketQueueDatabase
            // 
            this.ticketQueueDatabase.DataSetName = "TicketQueueDatabase";
            this.ticketQueueDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.DeleteBtn.Location = new System.Drawing.Point(601, 442);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // Logoff_btn
            // 
            this.Logoff_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Logoff_btn.Location = new System.Drawing.Point(1008, 442);
            this.Logoff_btn.Name = "Logoff_btn";
            this.Logoff_btn.Size = new System.Drawing.Size(75, 23);
            this.Logoff_btn.TabIndex = 21;
            this.Logoff_btn.Text = "Logoff";
            this.Logoff_btn.UseVisualStyleBackColor = true;
            this.Logoff_btn.Click += new System.EventHandler(this.Logoff_btn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.RefreshBtn.Location = new System.Drawing.Point(482, 442);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 22;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Analytics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.button2.Location = new System.Drawing.Point(1008, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TicketQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.Logoff_btn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TicketQueueDG);
            this.Controls.Add(this.label1);
            this.Name = "TicketQueue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen1";
            this.Load += new System.EventHandler(this.TicketQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketQueueDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueueDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TicketQueueDG;
        private System.Windows.Forms.Button DeleteBtn;
        private TicketQueueDatabase ticketQueueDatabase;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketQueueDatabaseTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.Button Logoff_btn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResolvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}