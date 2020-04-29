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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Homepage));
            this.Admin_Home_btn = new System.Windows.Forms.Button();
            this.Class_Erollment_btn = new System.Windows.Forms.Button();
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
            this.Admin_Home_btn.Location = new System.Drawing.Point(592, 433);
            this.Admin_Home_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin_Home_btn.Name = "Admin_Home_btn";
            this.Admin_Home_btn.Size = new System.Drawing.Size(176, 156);
            this.Admin_Home_btn.TabIndex = 7;
            this.Admin_Home_btn.Text = "Queue";
            this.Admin_Home_btn.UseVisualStyleBackColor = false;
            this.Admin_Home_btn.Click += new System.EventHandler(this.Admin_Home_btn_Click);
            // 
            // Class_Erollment_btn
            // 
            this.Class_Erollment_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Class_Erollment_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Class_Erollment_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Class_Erollment_btn.Location = new System.Drawing.Point(408, 433);
            this.Class_Erollment_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Class_Erollment_btn.Name = "Class_Erollment_btn";
            this.Class_Erollment_btn.Size = new System.Drawing.Size(176, 156);
            this.Class_Erollment_btn.TabIndex = 6;
            this.Class_Erollment_btn.Text = "Ticket Information";
            this.Class_Erollment_btn.UseVisualStyleBackColor = false;
            this.Class_Erollment_btn.Click += new System.EventHandler(this.Class_Erollment_btn_Click);
            // 
            // Create_Account_btn
            // 
            this.Create_Account_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Create_Account_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Create_Account_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Create_Account_btn.Location = new System.Drawing.Point(592, 269);
            this.Create_Account_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Create_Account_btn.Name = "Create_Account_btn";
            this.Create_Account_btn.Size = new System.Drawing.Size(176, 156);
            this.Create_Account_btn.TabIndex = 5;
            this.Create_Account_btn.Text = "Create Account";
            this.Create_Account_btn.UseVisualStyleBackColor = false;
            this.Create_Account_btn.Click += new System.EventHandler(this.Create_Account_btn_Click);
            // 
            // Third_Party_btn
            // 
            this.Third_Party_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Third_Party_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Third_Party_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Third_Party_btn.Location = new System.Drawing.Point(408, 269);
            this.Third_Party_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Third_Party_btn.Name = "Third_Party_btn";
            this.Third_Party_btn.Size = new System.Drawing.Size(176, 156);
            this.Third_Party_btn.TabIndex = 4;
            this.Third_Party_btn.Text = "3rd Party Complaint";
            this.Third_Party_btn.UseVisualStyleBackColor = false;
            this.Third_Party_btn.Click += new System.EventHandler(this.Third_Party_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1055, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Logoff";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1191, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Admin_Home_btn);
            this.Controls.Add(this.Class_Erollment_btn);
            this.Controls.Add(this.Create_Account_btn);
            this.Controls.Add(this.Third_Party_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Homepage";
            this.Load += new System.EventHandler(this.Admin_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin_Home_btn;
        private System.Windows.Forms.Button Class_Erollment_btn;
        private System.Windows.Forms.Button Create_Account_btn;
        private System.Windows.Forms.Button Third_Party_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}