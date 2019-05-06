namespace HOTELMANAGEMENT
{
    partial class frmLogin
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbt_Guest = new System.Windows.Forms.RadioButton();
            this.rbt_Receptionist = new System.Windows.Forms.RadioButton();
            this.rbt_Manager = new System.Windows.Forms.RadioButton();
            this.lbl_Register = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(126, 246);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 30);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "&Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.Location = new System.Drawing.Point(23, 246);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(94, 30);
            this.OK.TabIndex = 13;
            this.OK.Text = "&OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(14, 210);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 25);
            this.PasswordTextBox.TabIndex = 12;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(14, 153);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(220, 25);
            this.UsernameTextBox.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Teal;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 187);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Teal;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 130);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "&User name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "&Select Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbt_Guest
            // 
            this.rbt_Guest.AutoSize = true;
            this.rbt_Guest.Location = new System.Drawing.Point(15, 110);
            this.rbt_Guest.Name = "rbt_Guest";
            this.rbt_Guest.Size = new System.Drawing.Size(53, 17);
            this.rbt_Guest.TabIndex = 16;
            this.rbt_Guest.Text = "Guest";
            this.rbt_Guest.UseVisualStyleBackColor = true;
            this.rbt_Guest.CheckedChanged += new System.EventHandler(this.Rbt_Guest_CheckedChanged);
            // 
            // rbt_Receptionist
            // 
            this.rbt_Receptionist.AutoSize = true;
            this.rbt_Receptionist.Location = new System.Drawing.Point(74, 110);
            this.rbt_Receptionist.Name = "rbt_Receptionist";
            this.rbt_Receptionist.Size = new System.Drawing.Size(84, 17);
            this.rbt_Receptionist.TabIndex = 17;
            this.rbt_Receptionist.Text = "Receptionist";
            this.rbt_Receptionist.UseVisualStyleBackColor = true;
            this.rbt_Receptionist.CheckedChanged += new System.EventHandler(this.rbt_Receptionist_CheckedChanged);
            // 
            // rbt_Manager
            // 
            this.rbt_Manager.AutoSize = true;
            this.rbt_Manager.Location = new System.Drawing.Point(164, 110);
            this.rbt_Manager.Name = "rbt_Manager";
            this.rbt_Manager.Size = new System.Drawing.Size(67, 17);
            this.rbt_Manager.TabIndex = 18;
            this.rbt_Manager.Text = "Manager";
            this.rbt_Manager.UseVisualStyleBackColor = true;
            this.rbt_Manager.CheckedChanged += new System.EventHandler(this.Rbt_Manager_CheckedChanged);
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Register.LinkColor = System.Drawing.Color.Tomato;
            this.lbl_Register.Location = new System.Drawing.Point(96, 289);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(59, 16);
            this.lbl_Register.TabIndex = 19;
            this.lbl_Register.TabStop = true;
            this.lbl_Register.Text = "Register";
            this.lbl_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_Register_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(44, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "PANDAS HOTEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(95, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "LOGIN";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.rbt_Manager);
            this.Controls.Add(this.rbt_Receptionist);
            this.Controls.Add(this.rbt_Guest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.TextBox UsernameTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_Guest;
        private System.Windows.Forms.RadioButton rbt_Receptionist;
        private System.Windows.Forms.RadioButton rbt_Manager;
        private System.Windows.Forms.LinkLabel lbl_Register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}