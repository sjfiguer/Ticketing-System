namespace Ticketing_System
{
    partial class TicketInformation
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
            this.Update_btn = new System.Windows.Forms.Button();
            this.Resolved_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Tools_btn = new System.Windows.Forms.Button();
            this.ticketingSystemDataSet1 = new Ticketing_System.TicketingSystemDataSet1();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Ticketing_System.TicketingSystemDataSet1TableAdapters.TicketTableAdapter();
            this.Admin_Queue_DGV = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackoutDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Queue_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Information";
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Update_btn.Location = new System.Drawing.Point(866, 936);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(150, 44);
            this.Update_btn.TabIndex = 15;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Resolved_btn
            // 
            this.Resolved_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Resolved_btn.Location = new System.Drawing.Point(1318, 936);
            this.Resolved_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Resolved_btn.Name = "Resolved_btn";
            this.Resolved_btn.Size = new System.Drawing.Size(150, 44);
            this.Resolved_btn.TabIndex = 17;
            this.Resolved_btn.Text = "Resolved";
            this.Resolved_btn.UseVisualStyleBackColor = true;
            this.Resolved_btn.Click += new System.EventHandler(this.Resolved_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Exit_btn.Location = new System.Drawing.Point(1512, 936);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(150, 44);
            this.Exit_btn.TabIndex = 18;
            this.Exit_btn.Text = "Logoff";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Tools_btn
            // 
            this.Tools_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Tools_btn.Location = new System.Drawing.Point(1046, 936);
            this.Tools_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Tools_btn.Name = "Tools_btn";
            this.Tools_btn.Size = new System.Drawing.Size(226, 44);
            this.Tools_btn.TabIndex = 19;
            this.Tools_btn.Text = "Resolution Tools";
            this.Tools_btn.UseVisualStyleBackColor = true;
            this.Tools_btn.Click += new System.EventHandler(this.Tools_btn_Click);
            // 
            // ticketingSystemDataSet1
            // 
            this.ticketingSystemDataSet1.DataSetName = "TicketingSystemDataSet1";
            this.ticketingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.ticketingSystemDataSet1;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Queue_DGV
            // 
            this.Admin_Queue_DGV.AutoGenerateColumns = false;
            this.Admin_Queue_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_Queue_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.blackoutDataGridViewImageColumn,
            this.titleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.requestUserDataGridViewTextBoxColumn,
            this.assignedToDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.dateResolvedDataGridViewTextBoxColumn,
            this.catIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.Admin_Queue_DGV.DataSource = this.ticketBindingSource;
            this.Admin_Queue_DGV.Location = new System.Drawing.Point(108, 186);
            this.Admin_Queue_DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Admin_Queue_DGV.Name = "Admin_Queue_DGV";
            this.Admin_Queue_DGV.RowHeadersWidth = 51;
            this.Admin_Queue_DGV.RowTemplate.Height = 24;
            this.Admin_Queue_DGV.Size = new System.Drawing.Size(1554, 684);
            this.Admin_Queue_DGV.TabIndex = 20;
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
            // blackoutDataGridViewImageColumn
            // 
            this.blackoutDataGridViewImageColumn.DataPropertyName = "Blackout";
            this.blackoutDataGridViewImageColumn.HeaderText = "Blackout";
            this.blackoutDataGridViewImageColumn.MinimumWidth = 6;
            this.blackoutDataGridViewImageColumn.Name = "blackoutDataGridViewImageColumn";
            this.blackoutDataGridViewImageColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestUserDataGridViewTextBoxColumn
            // 
            this.requestUserDataGridViewTextBoxColumn.DataPropertyName = "RequestUser";
            this.requestUserDataGridViewTextBoxColumn.HeaderText = "RequestUser";
            this.requestUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestUserDataGridViewTextBoxColumn.Name = "requestUserDataGridViewTextBoxColumn";
            this.requestUserDataGridViewTextBoxColumn.Width = 125;
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
            // catIDDataGridViewTextBoxColumn
            // 
            this.catIDDataGridViewTextBoxColumn.DataPropertyName = "CatID";
            this.catIDDataGridViewTextBoxColumn.HeaderText = "CatID";
            this.catIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catIDDataGridViewTextBoxColumn.Name = "catIDDataGridViewTextBoxColumn";
            this.catIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // TicketInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 1054);
            this.Controls.Add(this.Admin_Queue_DGV);
            this.Controls.Add(this.Tools_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Resolved_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TicketInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen2";
            this.Load += new System.EventHandler(this.TicketInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Queue_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Resolved_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Tools_btn;
        private TicketingSystemDataSet1 ticketingSystemDataSet1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketingSystemDataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridView Admin_Queue_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn blackoutDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResolvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}