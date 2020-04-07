namespace Ticketing_System
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
            this.Admin_Home_btn = new System.Windows.Forms.Button();
            this.Student_Info_btn = new System.Windows.Forms.Button();
            this.Create_Account_btn = new System.Windows.Forms.Button();
            this.Third_Party_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_Home_btn
            // 
            this.Admin_Home_btn.Location = new System.Drawing.Point(514, 292);
            this.Admin_Home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_Home_btn.Name = "Admin_Home_btn";
            this.Admin_Home_btn.Size = new System.Drawing.Size(176, 156);
            this.Admin_Home_btn.TabIndex = 11;
            this.Admin_Home_btn.Text = "Queue";
            this.Admin_Home_btn.UseVisualStyleBackColor = true;
            // 
            // Student_Info_btn
            // 
            this.Student_Info_btn.Location = new System.Drawing.Point(330, 292);
            this.Student_Info_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Student_Info_btn.Name = "Student_Info_btn";
            this.Student_Info_btn.Size = new System.Drawing.Size(176, 156);
            this.Student_Info_btn.TabIndex = 10;
            this.Student_Info_btn.Text = "Student Info";
            this.Student_Info_btn.UseVisualStyleBackColor = true;
            // 
            // Create_Account_btn
            // 
            this.Create_Account_btn.Location = new System.Drawing.Point(514, 128);
            this.Create_Account_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Create_Account_btn.Name = "Create_Account_btn";
            this.Create_Account_btn.Size = new System.Drawing.Size(176, 156);
            this.Create_Account_btn.TabIndex = 9;
            this.Create_Account_btn.Text = "Create Account";
            this.Create_Account_btn.UseVisualStyleBackColor = true;
            // 
            // Third_Party_btn
            // 
            this.Third_Party_btn.Location = new System.Drawing.Point(330, 128);
            this.Third_Party_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Third_Party_btn.Name = "Third_Party_btn";
            this.Third_Party_btn.Size = new System.Drawing.Size(176, 156);
            this.Third_Party_btn.TabIndex = 8;
            this.Third_Party_btn.Text = "3rd Party Complaint";
            this.Third_Party_btn.UseVisualStyleBackColor = true;
            // 
            // Supervisor_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 576);
            this.Controls.Add(this.Admin_Home_btn);
            this.Controls.Add(this.Student_Info_btn);
            this.Controls.Add(this.Create_Account_btn);
            this.Controls.Add(this.Third_Party_btn);
            this.Name = "Supervisor_HomePage";
            this.Text = "Supervisor_HomePage";
            this.Load += new System.EventHandler(this.Supervisor_HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_Home_btn;
        private System.Windows.Forms.Button Student_Info_btn;
        private System.Windows.Forms.Button Create_Account_btn;
        private System.Windows.Forms.Button Third_Party_btn;
    }
}