﻿namespace Ticketing_System
{
    partial class Supervisor_HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor_HomePage));
            this.Admin_Home_btn = new System.Windows.Forms.Button();
            this.Student_Info_btn = new System.Windows.Forms.Button();
            this.Create_Account_btn = new System.Windows.Forms.Button();
            this.Third_Party_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_Home_btn
            // 
            this.Admin_Home_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Admin_Home_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Admin_Home_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Admin_Home_btn.Location = new System.Drawing.Point(940, 644);
            this.Admin_Home_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Admin_Home_btn.Name = "Admin_Home_btn";
            this.Admin_Home_btn.Size = new System.Drawing.Size(264, 244);
            this.Admin_Home_btn.TabIndex = 11;
            this.Admin_Home_btn.Text = "Queue";
            this.Admin_Home_btn.UseVisualStyleBackColor = false;
            // 
            // Student_Info_btn
            // 
            this.Student_Info_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Student_Info_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Student_Info_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Student_Info_btn.Location = new System.Drawing.Point(664, 644);
            this.Student_Info_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Student_Info_btn.Name = "Student_Info_btn";
            this.Student_Info_btn.Size = new System.Drawing.Size(264, 244);
            this.Student_Info_btn.TabIndex = 10;
            this.Student_Info_btn.Text = "Student Info";
            this.Student_Info_btn.UseVisualStyleBackColor = false;
            // 
            // Create_Account_btn
            // 
            this.Create_Account_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Create_Account_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Create_Account_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Create_Account_btn.Location = new System.Drawing.Point(940, 388);
            this.Create_Account_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Create_Account_btn.Name = "Create_Account_btn";
            this.Create_Account_btn.Size = new System.Drawing.Size(264, 244);
            this.Create_Account_btn.TabIndex = 9;
            this.Create_Account_btn.Text = "Create Account";
            this.Create_Account_btn.UseVisualStyleBackColor = false;
            // 
            // Third_Party_btn
            // 
            this.Third_Party_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Third_Party_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Third_Party_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Third_Party_btn.Location = new System.Drawing.Point(664, 388);
            this.Third_Party_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Third_Party_btn.Name = "Third_Party_btn";
            this.Third_Party_btn.Size = new System.Drawing.Size(264, 244);
            this.Third_Party_btn.TabIndex = 8;
            this.Third_Party_btn.Text = "3rd Party Complaint";
            this.Third_Party_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1792, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(664, 900);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(540, 94);
            this.button1.TabIndex = 24;
            this.button1.Text = "Analytics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Supervisor_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1786, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Admin_Home_btn);
            this.Controls.Add(this.Student_Info_btn);
            this.Controls.Add(this.Create_Account_btn);
            this.Controls.Add(this.Third_Party_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Supervisor_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor_HomePage";
            this.Load += new System.EventHandler(this.Supervisor_HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_Home_btn;
        private System.Windows.Forms.Button Student_Info_btn;
        private System.Windows.Forms.Button Create_Account_btn;
        private System.Windows.Forms.Button Third_Party_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}