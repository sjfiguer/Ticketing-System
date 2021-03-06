﻿namespace Ticketing_System
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
            this.ticketingSystemDataSet2 = new Ticketing_System.TicketingSystemDataSet2();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter1 = new Ticketing_System.TicketingSystemDataSet2TableAdapters.TicketTableAdapter();
            this.TCK_Info_RTB = new System.Windows.Forms.RichTextBox();
            this.Datetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Queue_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Information";
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Update_btn.Location = new System.Drawing.Point(577, 601);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(100, 33);
            this.Update_btn.TabIndex = 15;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Resolved_btn
            // 
            this.Resolved_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Resolved_btn.Location = new System.Drawing.Point(879, 601);
            this.Resolved_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Resolved_btn.Name = "Resolved_btn";
            this.Resolved_btn.Size = new System.Drawing.Size(100, 33);
            this.Resolved_btn.TabIndex = 17;
            this.Resolved_btn.Text = "Resolved";
            this.Resolved_btn.UseVisualStyleBackColor = true;
            this.Resolved_btn.Click += new System.EventHandler(this.Resolved_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Exit_btn.Location = new System.Drawing.Point(1008, 601);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 33);
            this.Exit_btn.TabIndex = 18;
            this.Exit_btn.Text = "Logoff";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Tools_btn
            // 
            this.Tools_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Tools_btn.Location = new System.Drawing.Point(697, 601);
            this.Tools_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tools_btn.Name = "Tools_btn";
            this.Tools_btn.Size = new System.Drawing.Size(151, 33);
            this.Tools_btn.TabIndex = 19;
            this.Tools_btn.Text = "Home Page";
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
            this.Admin_Queue_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_Queue_DGV.Location = new System.Drawing.Point(72, 121);
            this.Admin_Queue_DGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Admin_Queue_DGV.Name = "Admin_Queue_DGV";
            this.Admin_Queue_DGV.RowHeadersWidth = 51;
            this.Admin_Queue_DGV.RowTemplate.Height = 24;
            this.Admin_Queue_DGV.Size = new System.Drawing.Size(1036, 438);
            this.Admin_Queue_DGV.TabIndex = 20;
            this.Admin_Queue_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Admin_Queue_DGV_CellContentClick);
            // 
            // ticketingSystemDataSet2
            // 
            this.ticketingSystemDataSet2.DataSetName = "TicketingSystemDataSet2";
            this.ticketingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "Ticket";
            this.ticketBindingSource1.DataSource = this.ticketingSystemDataSet2;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // TCK_Info_RTB
            // 
            this.TCK_Info_RTB.Location = new System.Drawing.Point(72, 583);
            this.TCK_Info_RTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TCK_Info_RTB.Name = "TCK_Info_RTB";
            this.TCK_Info_RTB.Size = new System.Drawing.Size(496, 165);
            this.TCK_Info_RTB.TabIndex = 21;
            this.TCK_Info_RTB.Text = "";
            // 
            // Datetxt
            // 
            this.Datetxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Datetxt.Location = new System.Drawing.Point(1019, 15);
            this.Datetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.ReadOnly = true;
            this.Datetxt.Size = new System.Drawing.Size(132, 22);
            this.Datetxt.TabIndex = 22;
            // 
            // TicketInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1197, 767);
            this.Controls.Add(this.Datetxt);
            this.Controls.Add(this.TCK_Info_RTB);
            this.Controls.Add(this.Admin_Queue_DGV);
            this.Controls.Add(this.Tools_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Resolved_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScreen2";
            this.Load += new System.EventHandler(this.TicketInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Queue_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
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
        private TicketingSystemDataSet2 ticketingSystemDataSet2;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private TicketingSystemDataSet2TableAdapters.TicketTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.RichTextBox TCK_Info_RTB;
        private System.Windows.Forms.TextBox Datetxt;
    }
}