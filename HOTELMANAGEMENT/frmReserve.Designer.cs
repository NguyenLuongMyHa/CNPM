namespace HOTELMANAGEMENT
{
    partial class frmReserve
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddChildren = new System.Windows.Forms.Button();
            this.btnAddAdults = new System.Windows.Forms.Button();
            this.btnSubChildren = new System.Windows.Forms.Button();
            this.btnSubAdults = new System.Windows.Forms.Button();
            this.txtDiscountPayment = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.bttnSearchRoom = new System.Windows.Forms.Button();
            this.bttnSearchGuest = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnReserve = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtDaysNumber = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.bttnCheckin = new System.Windows.Forms.Button();
            this.bttnCancelReserve = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.dgvReservationList = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(746, 398);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.btnAddChildren);
            this.TabPage1.Controls.Add(this.btnAddAdults);
            this.TabPage1.Controls.Add(this.btnSubChildren);
            this.TabPage1.Controls.Add(this.btnSubAdults);
            this.TabPage1.Controls.Add(this.txtDiscountPayment);
            this.TabPage1.Controls.Add(this.label17);
            this.TabPage1.Controls.Add(this.dtCheckInDate);
            this.TabPage1.Controls.Add(this.lblAdvancePayment);
            this.TabPage1.Controls.Add(this.txtAdults);
            this.TabPage1.Controls.Add(this.txtChildren);
            this.TabPage1.Controls.Add(this.bttnSearchRoom);
            this.TabPage1.Controls.Add(this.bttnSearchGuest);
            this.TabPage1.Controls.Add(this.bttnCancel);
            this.TabPage1.Controls.Add(this.bttnReserve);
            this.TabPage1.Controls.Add(this.txtTotal);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.txtPayment);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.cboDiscount);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.txtDiscountRate);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.txtDaysNumber);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.dtCheckOutDate);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.txtRoomRate);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.txtRoomType);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txtRoomNumber);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtGuestName);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(738, 372);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Reservation Form";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddChildren
            // 
            this.btnAddChildren.Location = new System.Drawing.Point(666, 116);
            this.btnAddChildren.Name = "btnAddChildren";
            this.btnAddChildren.Size = new System.Drawing.Size(32, 25);
            this.btnAddChildren.TabIndex = 81;
            this.btnAddChildren.Text = "+";
            this.btnAddChildren.UseVisualStyleBackColor = true;
            this.btnAddChildren.Click += new System.EventHandler(this.BtnAddChildren_Click);
            // 
            // btnAddAdults
            // 
            this.btnAddAdults.Location = new System.Drawing.Point(666, 85);
            this.btnAddAdults.Name = "btnAddAdults";
            this.btnAddAdults.Size = new System.Drawing.Size(32, 25);
            this.btnAddAdults.TabIndex = 80;
            this.btnAddAdults.Text = "+";
            this.btnAddAdults.UseVisualStyleBackColor = true;
            this.btnAddAdults.Click += new System.EventHandler(this.BtnAddAdults_Click);
            // 
            // btnSubChildren
            // 
            this.btnSubChildren.Location = new System.Drawing.Point(628, 116);
            this.btnSubChildren.Name = "btnSubChildren";
            this.btnSubChildren.Size = new System.Drawing.Size(32, 25);
            this.btnSubChildren.TabIndex = 79;
            this.btnSubChildren.Text = "-";
            this.btnSubChildren.UseVisualStyleBackColor = true;
            this.btnSubChildren.Click += new System.EventHandler(this.BtnSubChildren_Click);
            // 
            // btnSubAdults
            // 
            this.btnSubAdults.Location = new System.Drawing.Point(628, 85);
            this.btnSubAdults.Name = "btnSubAdults";
            this.btnSubAdults.Size = new System.Drawing.Size(32, 25);
            this.btnSubAdults.TabIndex = 78;
            this.btnSubAdults.Text = "-";
            this.btnSubAdults.UseVisualStyleBackColor = true;
            this.btnSubAdults.Click += new System.EventHandler(this.BtnSubAdults_Click);
            // 
            // txtDiscountPayment
            // 
            this.txtDiscountPayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiscountPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPayment.Location = new System.Drawing.Point(552, 238);
            this.txtDiscountPayment.Multiline = true;
            this.txtDiscountPayment.Name = "txtDiscountPayment";
            this.txtDiscountPayment.ReadOnly = true;
            this.txtDiscountPayment.Size = new System.Drawing.Size(150, 25);
            this.txtDiscountPayment.TabIndex = 76;
            this.txtDiscountPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(448, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 16);
            this.label17.TabIndex = 77;
            this.label17.Text = "Discount";
            // 
            // dtCheckInDate
            // 
            this.dtCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckInDate.Location = new System.Drawing.Point(159, 217);
            this.dtCheckInDate.Name = "dtCheckInDate";
            this.dtCheckInDate.Size = new System.Drawing.Size(210, 22);
            this.dtCheckInDate.TabIndex = 75;
            this.dtCheckInDate.ValueChanged += new System.EventHandler(this.DtCheckInDate_ValueChanged);
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.ForeColor = System.Drawing.Color.Red;
            this.lblAdvancePayment.Location = new System.Drawing.Point(486, 240);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(0, 13);
            this.lblAdvancePayment.TabIndex = 74;
            this.lblAdvancePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(552, 85);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.Size = new System.Drawing.Size(70, 25);
            this.txtAdults.TabIndex = 69;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(552, 116);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(70, 25);
            this.txtChildren.TabIndex = 68;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnSearchRoom
            // 
            this.bttnSearchRoom.Location = new System.Drawing.Point(375, 122);
            this.bttnSearchRoom.Name = "bttnSearchRoom";
            this.bttnSearchRoom.Size = new System.Drawing.Size(30, 26);
            this.bttnSearchRoom.TabIndex = 67;
            this.bttnSearchRoom.Text = "...";
            this.bttnSearchRoom.UseVisualStyleBackColor = true;
            this.bttnSearchRoom.Click += new System.EventHandler(this.BttnSearchRoom_Click);
            // 
            // bttnSearchGuest
            // 
            this.bttnSearchGuest.Location = new System.Drawing.Point(375, 91);
            this.bttnSearchGuest.Name = "bttnSearchGuest";
            this.bttnSearchGuest.Size = new System.Drawing.Size(30, 26);
            this.bttnSearchGuest.TabIndex = 66;
            this.bttnSearchGuest.Text = "...";
            this.bttnSearchGuest.UseVisualStyleBackColor = true;
            this.bttnSearchGuest.Click += new System.EventHandler(this.BttnSearchGuest_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(589, 311);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(113, 35);
            this.bttnCancel.TabIndex = 65;
            this.bttnCancel.Text = "C&ancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.BttnCancel_Click);
            // 
            // bttnReserve
            // 
            this.bttnReserve.Location = new System.Drawing.Point(469, 311);
            this.bttnReserve.Name = "bttnReserve";
            this.bttnReserve.Size = new System.Drawing.Size(113, 35);
            this.bttnReserve.TabIndex = 64;
            this.bttnReserve.Text = "&Reserve";
            this.bttnReserve.UseVisualStyleBackColor = true;
            this.bttnReserve.Click += new System.EventHandler(this.BttnReserve_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(552, 269);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 25);
            this.txtTotal.TabIndex = 53;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(448, 273);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(39, 16);
            this.Label15.TabIndex = 63;
            this.Label15.Text = "Total";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(553, 207);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(150, 25);
            this.txtPayment.TabIndex = 52;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(449, 211);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 16);
            this.Label14.TabIndex = 62;
            this.Label14.Text = "Payment";
            // 
            // cboDiscount
            // 
            this.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(553, 147);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(149, 21);
            this.cboDiscount.TabIndex = 51;
            this.cboDiscount.SelectedIndexChanged += new System.EventHandler(this.CboDiscount_SelectedIndexChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(449, 149);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(95, 16);
            this.Label13.TabIndex = 61;
            this.Label13.Text = "Discount Type";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(449, 115);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 16);
            this.Label12.TabIndex = 60;
            this.Label12.Text = "No. Of Children";
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDiscountRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountRate.Location = new System.Drawing.Point(553, 176);
            this.txtDiscountRate.Multiline = true;
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.ReadOnly = true;
            this.txtDiscountRate.Size = new System.Drawing.Size(150, 25);
            this.txtDiscountRate.TabIndex = 49;
            this.txtDiscountRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(449, 179);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(92, 16);
            this.Label11.TabIndex = 59;
            this.Label11.Text = "Discount Rate";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(449, 85);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 16);
            this.Label10.TabIndex = 58;
            this.Label10.Text = "No. Of Adults";
            // 
            // txtDaysNumber
            // 
            this.txtDaysNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDaysNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysNumber.Location = new System.Drawing.Point(159, 274);
            this.txtDaysNumber.Multiline = true;
            this.txtDaysNumber.Name = "txtDaysNumber";
            this.txtDaysNumber.ReadOnly = true;
            this.txtDaysNumber.Size = new System.Drawing.Size(210, 25);
            this.txtDaysNumber.TabIndex = 44;
            this.txtDaysNumber.Text = "0";
            this.txtDaysNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDaysNumber.TextChanged += new System.EventHandler(this.TxtDaysNumber_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(38, 278);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(80, 16);
            this.Label9.TabIndex = 57;
            this.Label9.Text = "No. Of Days";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(38, 219);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 16);
            this.Label8.TabIndex = 55;
            this.Label8.Text = "Check In Date";
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOutDate.Location = new System.Drawing.Point(159, 246);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.Size = new System.Drawing.Size(210, 22);
            this.dtCheckOutDate.TabIndex = 43;
            this.dtCheckOutDate.ValueChanged += new System.EventHandler(this.DtCheckOutDate_ValueChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(38, 248);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(101, 16);
            this.Label7.TabIndex = 54;
            this.Label7.Text = "Check Out Date";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(159, 185);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(210, 25);
            this.txtRoomRate.TabIndex = 42;
            this.txtRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(38, 190);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(77, 16);
            this.Label6.TabIndex = 50;
            this.Label6.Text = "Room Rate";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(159, 154);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(210, 25);
            this.txtRoomType.TabIndex = 40;
            this.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(38, 159);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 16);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "Room Type";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(159, 123);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.Size = new System.Drawing.Size(210, 25);
            this.txtRoomNumber.TabIndex = 38;
            this.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(38, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 16);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "Room Number";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(159, 92);
            this.txtGuestName.Multiline = true;
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.ReadOnly = true;
            this.txtGuestName.Size = new System.Drawing.Size(210, 25);
            this.txtGuestName.TabIndex = 35;
            this.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(38, 97);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 16);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Guest Name";
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(175, 24);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Reservation Form";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.dgvReservationList);
            this.TabPage2.Controls.Add(this.bttnCheckin);
            this.TabPage2.Controls.Add(this.bttnCancelReserve);
            this.TabPage2.Controls.Add(this.Label16);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(738, 372);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Reservation List";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // bttnCheckin
            // 
            this.bttnCheckin.Location = new System.Drawing.Point(493, 331);
            this.bttnCheckin.Name = "bttnCheckin";
            this.bttnCheckin.Size = new System.Drawing.Size(94, 30);
            this.bttnCheckin.TabIndex = 41;
            this.bttnCheckin.Text = "&Checkin";
            this.bttnCheckin.UseVisualStyleBackColor = true;
            // 
            // bttnCancelReserve
            // 
            this.bttnCancelReserve.Location = new System.Drawing.Point(593, 330);
            this.bttnCancelReserve.Name = "bttnCancelReserve";
            this.bttnCancelReserve.Size = new System.Drawing.Size(130, 30);
            this.bttnCancelReserve.TabIndex = 40;
            this.bttnCancelReserve.Text = "Cancel &Reservation";
            this.bttnCancelReserve.UseVisualStyleBackColor = true;
            // 
            // Label16
            // 
            this.Label16.AutoEllipsis = true;
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(10, 24);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(157, 24);
            this.Label16.TabIndex = 37;
            this.Label16.Text = "Reservation List";
            // 
            // dgvReservationList
            // 
            this.dgvReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationList.Location = new System.Drawing.Point(15, 51);
            this.dgvReservationList.Name = "dgvReservationList";
            this.dgvReservationList.Size = new System.Drawing.Size(708, 273);
            this.dgvReservationList.TabIndex = 42;
            // 
            // frmReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 420);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmReserve";
            this.Text = "frmReserve";
            this.Load += new System.EventHandler(this.FrmReserve_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DateTimePicker dtCheckInDate;
        internal System.Windows.Forms.Label lblAdvancePayment;
        internal System.Windows.Forms.TextBox txtAdults;
        internal System.Windows.Forms.TextBox txtChildren;
        internal System.Windows.Forms.Button bttnSearchRoom;
        internal System.Windows.Forms.Button bttnSearchGuest;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnReserve;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtPayment;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox cboDiscount;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtDiscountRate;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtDaysNumber;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DateTimePicker dtCheckOutDate;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtRoomRate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtRoomType;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtRoomNumber;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtGuestName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button bttnCheckin;
        internal System.Windows.Forms.Button bttnCancelReserve;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtDiscountPayment;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddChildren;
        private System.Windows.Forms.Button btnAddAdults;
        private System.Windows.Forms.Button btnSubChildren;
        private System.Windows.Forms.Button btnSubAdults;
        private System.Windows.Forms.DataGridView dgvReservationList;
    }
}