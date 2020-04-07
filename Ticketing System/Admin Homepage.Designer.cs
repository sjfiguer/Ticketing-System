namespace Ticketing_System
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
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Class_Erollment_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Summary_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(560, 331);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(176, 156);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // Class_Erollment_btn
            // 
            this.Class_Erollment_btn.Location = new System.Drawing.Point(376, 331);
            this.Class_Erollment_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Class_Erollment_btn.Name = "Class_Erollment_btn";
            this.Class_Erollment_btn.Size = new System.Drawing.Size(176, 156);
            this.Class_Erollment_btn.TabIndex = 6;
            this.Class_Erollment_btn.Text = "Classes and Enrollment";
            this.Class_Erollment_btn.UseVisualStyleBackColor = true;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(560, 167);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(176, 156);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // Summary_btn
            // 
            this.Summary_btn.Location = new System.Drawing.Point(376, 167);
            this.Summary_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Summary_btn.Name = "Summary_btn";
            this.Summary_btn.Size = new System.Drawing.Size(176, 156);
            this.Summary_btn.TabIndex = 4;
            this.Summary_btn.Text = "Summary";
            this.Summary_btn.UseVisualStyleBackColor = true;
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 655);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Class_Erollment_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Summary_btn);
            this.Name = "Admin_Homepage";
            this.Text = "Admin_Homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Class_Erollment_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Summary_btn;
    }
}