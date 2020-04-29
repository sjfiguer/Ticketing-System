namespace Ticketing_System
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TPadminIDtxt = new System.Windows.Forms.TextBox();
            this.MessageBoxTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.TPventypeCmb = new System.Windows.Forms.ComboBox();
            this.TPemailCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label1.Location = new System.Drawing.Point(253, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin. ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(603, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor Type:";
            // 
            // TPadminIDtxt
            // 
            this.TPadminIDtxt.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPadminIDtxt.Location = new System.Drawing.Point(361, 247);
            this.TPadminIDtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TPadminIDtxt.Multiline = true;
            this.TPadminIDtxt.Name = "TPadminIDtxt";
            this.TPadminIDtxt.Size = new System.Drawing.Size(159, 24);
            this.TPadminIDtxt.TabIndex = 3;
            this.TPadminIDtxt.TextChanged += new System.EventHandler(this.TPadminIDtxt_TextChanged);
            // 
            // MessageBoxTxt
            // 
            this.MessageBoxTxt.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.MessageBoxTxt.Location = new System.Drawing.Point(257, 389);
            this.MessageBoxTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessageBoxTxt.Multiline = true;
            this.MessageBoxTxt.Name = "MessageBoxTxt";
            this.MessageBoxTxt.Size = new System.Drawing.Size(641, 196);
            this.MessageBoxTxt.TabIndex = 6;
            this.MessageBoxTxt.TextChanged += new System.EventHandler(this.MessageBoxTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(253, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.ClearBtn.Location = new System.Drawing.Point(257, 602);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(99, 28);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.DarkRed;
            this.SendBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.SendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SendBtn.Location = new System.Drawing.Point(800, 602);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(99, 28);
            this.SendBtn.TabIndex = 10;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // TPventypeCmb
            // 
            this.TPventypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPventypeCmb.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPventypeCmb.FormattingEnabled = true;
            this.TPventypeCmb.Location = new System.Drawing.Point(740, 245);
            this.TPventypeCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPventypeCmb.Name = "TPventypeCmb";
            this.TPventypeCmb.Size = new System.Drawing.Size(159, 29);
            this.TPventypeCmb.TabIndex = 16;
            this.TPventypeCmb.SelectedIndexChanged += new System.EventHandler(this.TPventypeCmb_SelectedIndexChanged);
            // 
            // TPemailCmb
            // 
            this.TPemailCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TPemailCmb.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPemailCmb.FormattingEnabled = true;
            this.TPemailCmb.Location = new System.Drawing.Point(740, 293);
            this.TPemailCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPemailCmb.Name = "TPemailCmb";
            this.TPemailCmb.Size = new System.Drawing.Size(159, 29);
            this.TPemailCmb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(603, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vendor Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-52, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backbtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(1062, 199);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(83, 35);
            this.backbtn.TabIndex = 25;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1191, 652);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TPemailCmb);
            this.Controls.Add(this.TPventypeCmb);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageBoxTxt);
            this.Controls.Add(this.TPadminIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThirdParty";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TPadminIDtxt;
        private System.Windows.Forms.TextBox MessageBoxTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.ComboBox TPventypeCmb;
        private System.Windows.Forms.ComboBox TPemailCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backbtn;
    }
}

