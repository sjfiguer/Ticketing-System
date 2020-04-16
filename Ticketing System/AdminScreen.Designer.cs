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
            this.Back_btn = new System.Windows.Forms.Button();
            this.TPventypeCmb = new System.Windows.Forms.ComboBox();
            this.TPemailCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label1.Location = new System.Drawing.Point(380, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin. ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label3.Location = new System.Drawing.Point(905, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor Type:";
            // 
            // TPadminIDtxt
            // 
            this.TPadminIDtxt.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPadminIDtxt.Location = new System.Drawing.Point(542, 386);
            this.TPadminIDtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TPadminIDtxt.Multiline = true;
            this.TPadminIDtxt.Name = "TPadminIDtxt";
            this.TPadminIDtxt.Size = new System.Drawing.Size(237, 35);
            this.TPadminIDtxt.TabIndex = 3;
            this.TPadminIDtxt.TextChanged += new System.EventHandler(this.TPadminIDtxt_TextChanged);
            // 
            // MessageBoxTxt
            // 
            this.MessageBoxTxt.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.MessageBoxTxt.Location = new System.Drawing.Point(386, 608);
            this.MessageBoxTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MessageBoxTxt.Multiline = true;
            this.MessageBoxTxt.Name = "MessageBoxTxt";
            this.MessageBoxTxt.Size = new System.Drawing.Size(961, 304);
            this.MessageBoxTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label4.Location = new System.Drawing.Point(380, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.ClearBtn.Location = new System.Drawing.Point(386, 940);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(149, 44);
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
            this.SendBtn.Location = new System.Drawing.Point(1199, 940);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(149, 44);
            this.SendBtn.TabIndex = 10;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Back_btn.Location = new System.Drawing.Point(1373, 1091);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(149, 44);
            this.Back_btn.TabIndex = 11;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // TPventypeCmb
            // 
            this.TPventypeCmb.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPventypeCmb.FormattingEnabled = true;
            this.TPventypeCmb.Location = new System.Drawing.Point(1110, 383);
            this.TPventypeCmb.Margin = new System.Windows.Forms.Padding(4);
            this.TPventypeCmb.Name = "TPventypeCmb";
            this.TPventypeCmb.Size = new System.Drawing.Size(237, 42);
            this.TPventypeCmb.TabIndex = 16;
            this.TPventypeCmb.SelectedIndexChanged += new System.EventHandler(this.TPventypeCmb_SelectedIndexChanged);
            // 
            // TPemailCmb
            // 
            this.TPemailCmb.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.TPemailCmb.FormattingEnabled = true;
            this.TPemailCmb.Location = new System.Drawing.Point(1110, 458);
            this.TPemailCmb.Margin = new System.Windows.Forms.Padding(4);
            this.TPemailCmb.Name = "TPemailCmb";
            this.TPemailCmb.Size = new System.Drawing.Size(237, 42);
            this.TPemailCmb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(905, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vendor Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-78, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1918, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 1054);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TPemailCmb);
            this.Controls.Add(this.TPventypeCmb);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageBoxTxt);
            this.Controls.Add(this.TPadminIDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThirdParty";
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
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.ComboBox TPventypeCmb;
        private System.Windows.Forms.ComboBox TPemailCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

