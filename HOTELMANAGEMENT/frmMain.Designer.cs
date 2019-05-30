namespace HOTELMANAGEMENT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MenuStripManager = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckedInListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckedOutListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RoomStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbarCheckIn = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarCheckOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarReserve = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarRoom = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarGuest = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarLogout = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripInfo = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStripManager.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripManager
            // 
            this.MenuStripManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.SettingsToolStripMenuItem,
            this.SettingsToolStripMenuItem1});
            this.MenuStripManager.Location = new System.Drawing.Point(0, 0);
            this.MenuStripManager.Name = "MenuStripManager";
            this.MenuStripManager.Size = new System.Drawing.Size(892, 24);
            this.MenuStripManager.TabIndex = 17;
            this.MenuStripManager.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCheckInToolStripMenuItem,
            this.NewReservationToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.LogoutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem1.Text = "&File";
            // 
            // NewCheckInToolStripMenuItem
            // 
            this.NewCheckInToolStripMenuItem.Name = "NewCheckInToolStripMenuItem";
            this.NewCheckInToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewCheckInToolStripMenuItem.Text = "New Check In";
            // 
            // NewReservationToolStripMenuItem
            // 
            this.NewReservationToolStripMenuItem.Name = "NewReservationToolStripMenuItem";
            this.NewReservationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewReservationToolStripMenuItem.Text = "New Reservation";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.ToolBarLogout_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ToolBarExit_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckedInListToolStripMenuItem,
            this.ReservedListToolStripMenuItem,
            this.CheckedOutListToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.RoomStatusToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SettingsToolStripMenuItem.Text = "&Report";
            // 
            // CheckedInListToolStripMenuItem
            // 
            this.CheckedInListToolStripMenuItem.Name = "CheckedInListToolStripMenuItem";
            this.CheckedInListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CheckedInListToolStripMenuItem.Text = "&Checked In List";
            // 
            // ReservedListToolStripMenuItem
            // 
            this.ReservedListToolStripMenuItem.Name = "ReservedListToolStripMenuItem";
            this.ReservedListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ReservedListToolStripMenuItem.Text = "&Reserved List";
            // 
            // CheckedOutListToolStripMenuItem
            // 
            this.CheckedOutListToolStripMenuItem.Name = "CheckedOutListToolStripMenuItem";
            this.CheckedOutListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CheckedOutListToolStripMenuItem.Text = "Checked &Out List";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // RoomStatusToolStripMenuItem
            // 
            this.RoomStatusToolStripMenuItem.Name = "RoomStatusToolStripMenuItem";
            this.RoomStatusToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RoomStatusToolStripMenuItem.Text = "&Room Status";
            // 
            // SettingsToolStripMenuItem1
            // 
            this.SettingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiscountToolStripMenuItem,
            this.RoomToolStripMenuItem,
            this.GuestToolStripMenuItem});
            this.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1";
            this.SettingsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem1.Text = "&Settings";
            // 
            // DiscountToolStripMenuItem
            // 
            this.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem";
            this.DiscountToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.DiscountToolStripMenuItem.Text = "&Discount";
            // 
            // RoomToolStripMenuItem
            // 
            this.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem";
            this.RoomToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.RoomToolStripMenuItem.Text = "&Room";
            // 
            // GuestToolStripMenuItem
            // 
            this.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem";
            this.GuestToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.GuestToolStripMenuItem.Text = "&Guest";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarCheckIn,
            this.ToolStripButton11,
            this.toolbarCheckOut,
            this.ToolStripSeparator6,
            this.toolbarReserve,
            this.ToolStripSeparator7,
            this.toolbarRoom,
            this.ToolStripSeparator8,
            this.ToolBarGuest,
            this.ToolStripSeparator9,
            this.ToolBarLogout,
            this.ToolStripSeparator10,
            this.ToolBarExit,
            this.toolStripSeparator1,
            this.toolStripInfo});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(892, 39);
            this.ToolStrip1.TabIndex = 18;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolbarCheckIn
            // 
            this.toolbarCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckIn.Image")));
            this.toolbarCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckIn.Name = "toolbarCheckIn";
            this.toolbarCheckIn.Size = new System.Drawing.Size(91, 36);
            this.toolbarCheckIn.Text = "Check-in";
            this.toolbarCheckIn.ToolTipText = "Checkin";
            this.toolbarCheckIn.Click += new System.EventHandler(this.ToolbarCheckIn_Click);
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarCheckOut
            // 
            this.toolbarCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCheckOut.Image")));
            this.toolbarCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCheckOut.Name = "toolbarCheckOut";
            this.toolbarCheckOut.Size = new System.Drawing.Size(94, 36);
            this.toolbarCheckOut.Text = "Checkout";
            this.toolbarCheckOut.ToolTipText = "Checkout";
            this.toolbarCheckOut.Click += new System.EventHandler(this.ToolbarCheckOut_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarReserve
            // 
            this.toolbarReserve.Image = ((System.Drawing.Image)(resources.GetObject("toolbarReserve.Image")));
            this.toolbarReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarReserve.Name = "toolbarReserve";
            this.toolbarReserve.Size = new System.Drawing.Size(104, 36);
            this.toolbarReserve.Text = "Reservation";
            this.toolbarReserve.ToolTipText = "Reserve";
            this.toolbarReserve.Click += new System.EventHandler(this.ToolbarReserve_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // toolbarRoom
            // 
            this.toolbarRoom.Image = ((System.Drawing.Image)(resources.GetObject("toolbarRoom.Image")));
            this.toolbarRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarRoom.Name = "toolbarRoom";
            this.toolbarRoom.Size = new System.Drawing.Size(80, 36);
            this.toolbarRoom.Text = "Rooms";
            this.toolbarRoom.ToolTipText = "Room";
            this.toolbarRoom.Click += new System.EventHandler(this.ToolbarRoom_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBarGuest
            // 
            this.ToolBarGuest.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarGuest.Image")));
            this.ToolBarGuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarGuest.Name = "ToolBarGuest";
            this.ToolBarGuest.Size = new System.Drawing.Size(132, 36);
            this.ToolBarGuest.Text = "User Information";
            this.ToolBarGuest.ToolTipText = "Guest";
            this.ToolBarGuest.Click += new System.EventHandler(this.ToolBarGuest_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBarLogout
            // 
            this.ToolBarLogout.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarLogout.Image")));
            this.ToolBarLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarLogout.Name = "ToolBarLogout";
            this.ToolBarLogout.Size = new System.Drawing.Size(81, 36);
            this.ToolBarLogout.Text = "Logout";
            this.ToolBarLogout.ToolTipText = "Logout";
            this.ToolBarLogout.Click += new System.EventHandler(this.ToolBarLogout_Click);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // ToolBarExit
            // 
            this.ToolBarExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarExit.Image")));
            this.ToolBarExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarExit.Name = "ToolBarExit";
            this.ToolBarExit.Size = new System.Drawing.Size(61, 36);
            this.ToolBarExit.Text = "Exit";
            this.ToolBarExit.ToolTipText = "Exit";
            this.ToolBarExit.Click += new System.EventHandler(this.ToolBarExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(28, 36);
            this.toolStripInfo.Text = "info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 231);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(325, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome to Pandas Hotel";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStripManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuStripManager.ResumeLayout(false);
            this.MenuStripManager.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStripManager;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem NewCheckInToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewReservationToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CheckedInListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ReservedListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CheckedOutListToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem RoomStatusToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem DiscountToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RoomToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GuestToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton toolbarCheckIn;
        internal System.Windows.Forms.ToolStripSeparator ToolStripButton11;
        internal System.Windows.Forms.ToolStripButton toolbarCheckOut;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton toolbarReserve;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton toolbarRoom;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripButton ToolBarGuest;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripButton ToolBarLogout;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator10;
        internal System.Windows.Forms.ToolStripButton ToolBarExit;
        private System.Windows.Forms.ToolStripLabel toolStripInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}