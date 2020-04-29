namespace CS_Assignment
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.UsernameLB = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.User_Type_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketingSystemDataSet = new Ticketing_System.TicketingSystemDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Ticketing_System.TicketingSystemDataSetTableAdapters.LoginTableAdapter();
            this.LoginIDtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameLB.Location = new System.Drawing.Point(301, 263);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(90, 20);
            this.UsernameLB.TabIndex = 0;
            this.UsernameLB.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(404, 264);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordLB.Location = new System.Drawing.Point(301, 315);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(87, 20);
            this.PasswordLB.TabIndex = 2;
            this.PasswordLB.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(404, 315);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Location = new System.Drawing.Point(454, 414);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(104, 39);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.Enter += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(310, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Mongolian Baiti", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.RegistrationLabel.Location = new System.Drawing.Point(284, 205);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(310, 31);
            this.RegistrationLabel.TabIndex = 6;
            this.RegistrationLabel.Text = "Welcome Please Log In!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(825, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // User_Type_cmbox
            // 
            this.User_Type_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.User_Type_cmbox.FormattingEnabled = true;
            this.User_Type_cmbox.Location = new System.Drawing.Point(404, 369);
            this.User_Type_cmbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_Type_cmbox.Name = "User_Type_cmbox";
            this.User_Type_cmbox.Size = new System.Drawing.Size(165, 21);
            this.User_Type_cmbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(307, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // ticketingSystemDataSet
            // 
            this.ticketingSystemDataSet.DataSetName = "TicketingSystemDataSet";
            this.ticketingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.ticketingSystemDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // LoginIDtxt
            // 
            this.LoginIDtxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoginIDtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginIDtxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LoginIDtxt.Location = new System.Drawing.Point(79, 426);
            this.LoginIDtxt.Name = "LoginIDtxt";
            this.LoginIDtxt.ReadOnly = true;
            this.LoginIDtxt.Size = new System.Drawing.Size(100, 13);
            this.LoginIDtxt.TabIndex = 43;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.LoginIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_Type_cmbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.UsernameLB);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLB;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox User_Type_cmbox;
        private System.Windows.Forms.Label label1;
        private Ticketing_System.TicketingSystemDataSet ticketingSystemDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Ticketing_System.TicketingSystemDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.TextBox LoginIDtxt;
    }
}

