﻿namespace Ticketing_System
{
    partial class Admin_Homepage
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
            this.Admin_Home_btn = new System.Windows.Forms.Button();
            this.Class_Erollment_btn = new System.Windows.Forms.Button();
            this.Create_Account_btn = new System.Windows.Forms.Button();
            this.Third_Party_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_Home_btn
            // 
            this.Admin_Home_btn.Location = new System.Drawing.Point(560, 331);
            this.Admin_Home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_Home_btn.Name = "Admin_Home_btn";
            this.Admin_Home_btn.Size = new System.Drawing.Size(176, 156);
            this.Admin_Home_btn.TabIndex = 7;
            this.Admin_Home_btn.Text = "Queue";
            this.Admin_Home_btn.UseVisualStyleBackColor = true;
            this.Admin_Home_btn.Click += new System.EventHandler(this.Admin_Home_btn_Click);
            // 
            // Class_Erollment_btn
            // 
            this.Class_Erollment_btn.Location = new System.Drawing.Point(376, 331);
            this.Class_Erollment_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Class_Erollment_btn.Name = "Class_Erollment_btn";
            this.Class_Erollment_btn.Size = new System.Drawing.Size(176, 156);
            this.Class_Erollment_btn.TabIndex = 6;
            this.Class_Erollment_btn.Text = "Student Info";
            this.Class_Erollment_btn.UseVisualStyleBackColor = true;
            this.Class_Erollment_btn.Click += new System.EventHandler(this.Class_Erollment_btn_Click);
            // 
            // Create_Account_btn
            // 
            this.Create_Account_btn.Location = new System.Drawing.Point(560, 167);
            this.Create_Account_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Create_Account_btn.Name = "Create_Account_btn";
            this.Create_Account_btn.Size = new System.Drawing.Size(176, 156);
            this.Create_Account_btn.TabIndex = 5;
            this.Create_Account_btn.Text = "Create Account";
            this.Create_Account_btn.UseVisualStyleBackColor = true;
            this.Create_Account_btn.Click += new System.EventHandler(this.Create_Account_btn_Click);
            // 
            // Third_Party_btn
            // 
            this.Third_Party_btn.Location = new System.Drawing.Point(376, 167);
            this.Third_Party_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Third_Party_btn.Name = "Third_Party_btn";
            this.Third_Party_btn.Size = new System.Drawing.Size(176, 156);
            this.Third_Party_btn.TabIndex = 4;
            this.Third_Party_btn.Text = "3rd Party Complaint";
            this.Third_Party_btn.UseVisualStyleBackColor = true;
            this.Third_Party_btn.Click += new System.EventHandler(this.Third_Party_btn_Click);
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 655);
            this.Controls.Add(this.Admin_Home_btn);
            this.Controls.Add(this.Class_Erollment_btn);
            this.Controls.Add(this.Create_Account_btn);
            this.Controls.Add(this.Third_Party_btn);
            this.Name = "Admin_Homepage";
            this.Text = "Admin_Homepage";
            this.Load += new System.EventHandler(this.Admin_Homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_Home_btn;
        private System.Windows.Forms.Button Class_Erollment_btn;
        private System.Windows.Forms.Button Create_Account_btn;
        private System.Windows.Forms.Button Third_Party_btn;
    }
}