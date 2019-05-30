namespace HOTELMANAGEMENT
{
    partial class frmRoom
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
            this.Tab_Room = new System.Windows.Forms.TabControl();
            this.TabPageNewRoom = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.txtNoOfOccupancy = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TabPageRoomList = new System.Windows.Forms.TabPage();
            this.btn_RoomDelete = new System.Windows.Forms.Button();
            this.btn_RoomCancel = new System.Windows.Forms.Button();
            this.dgv_RoomList = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            this.Tab_Room.SuspendLayout();
            this.TabPageNewRoom.SuspendLayout();
            this.TabPageRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Room
            // 
            this.Tab_Room.Controls.Add(this.TabPageNewRoom);
            this.Tab_Room.Controls.Add(this.TabPageRoomList);
            this.Tab_Room.Location = new System.Drawing.Point(12, 12);
            this.Tab_Room.Name = "Tab_Room";
            this.Tab_Room.SelectedIndex = 0;
            this.Tab_Room.Size = new System.Drawing.Size(607, 314);
            this.Tab_Room.TabIndex = 1;
            // 
            // TabPageNewRoom
            // 
            this.TabPageNewRoom.Controls.Add(this.btnCancel);
            this.TabPageNewRoom.Controls.Add(this.btnRoomSave);
            this.TabPageNewRoom.Controls.Add(this.txtNoOfOccupancy);
            this.TabPageNewRoom.Controls.Add(this.Label4);
            this.TabPageNewRoom.Controls.Add(this.txtRoomRate);
            this.TabPageNewRoom.Controls.Add(this.Label2);
            this.TabPageNewRoom.Controls.Add(this.txtRoomType);
            this.TabPageNewRoom.Controls.Add(this.Label1);
            this.TabPageNewRoom.Controls.Add(this.txtRoomNumber);
            this.TabPageNewRoom.Controls.Add(this.Label3);
            this.TabPageNewRoom.Controls.Add(this.Label9);
            this.TabPageNewRoom.Location = new System.Drawing.Point(4, 22);
            this.TabPageNewRoom.Name = "TabPageNewRoom";
            this.TabPageNewRoom.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNewRoom.Size = new System.Drawing.Size(599, 288);
            this.TabPageNewRoom.TabIndex = 0;
            this.TabPageNewRoom.Text = "New Room";
            this.TabPageNewRoom.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 31);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.Location = new System.Drawing.Point(387, 251);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(100, 31);
            this.btnRoomSave.TabIndex = 68;
            this.btnRoomSave.Text = "&Save";
            this.btnRoomSave.UseVisualStyleBackColor = true;
            this.btnRoomSave.Click += new System.EventHandler(this.BtnRoomSave_Click);
            // 
            // txtNoOfOccupancy
            // 
            this.txtNoOfOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfOccupancy.Location = new System.Drawing.Point(170, 183);
            this.txtNoOfOccupancy.Multiline = true;
            this.txtNoOfOccupancy.Name = "txtNoOfOccupancy";
            this.txtNoOfOccupancy.Size = new System.Drawing.Size(170, 25);
            this.txtNoOfOccupancy.TabIndex = 66;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(23, 186);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(141, 16);
            this.Label4.TabIndex = 67;
            this.Label4.Text = "Number of Occupancy";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomRate.Location = new System.Drawing.Point(170, 141);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(170, 25);
            this.txtRoomRate.TabIndex = 64;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 144);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 16);
            this.Label2.TabIndex = 65;
            this.Label2.Text = "Room Rate";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(170, 100);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(170, 25);
            this.txtRoomType.TabIndex = 62;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(23, 103);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "Room Type";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(170, 60);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(170, 25);
            this.txtRoomNumber.TabIndex = 60;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(23, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 16);
            this.Label3.TabIndex = 61;
            this.Label3.Text = "Room Number";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(19, 22);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(113, 24);
            this.Label9.TabIndex = 59;
            this.Label9.Text = "New Room";
            // 
            // TabPageRoomList
            // 
            this.TabPageRoomList.Controls.Add(this.btn_RoomDelete);
            this.TabPageRoomList.Controls.Add(this.btn_RoomCancel);
            this.TabPageRoomList.Controls.Add(this.dgv_RoomList);
            this.TabPageRoomList.Controls.Add(this.Label5);
            this.TabPageRoomList.Location = new System.Drawing.Point(4, 22);
            this.TabPageRoomList.Name = "TabPageRoomList";
            this.TabPageRoomList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRoomList.Size = new System.Drawing.Size(599, 288);
            this.TabPageRoomList.TabIndex = 1;
            this.TabPageRoomList.Text = "Room List";
            this.TabPageRoomList.UseVisualStyleBackColor = true;
            // 
            // btn_RoomDelete
            // 
            this.btn_RoomDelete.Location = new System.Drawing.Point(387, 251);
            this.btn_RoomDelete.Name = "btn_RoomDelete";
            this.btn_RoomDelete.Size = new System.Drawing.Size(100, 31);
            this.btn_RoomDelete.TabIndex = 71;
            this.btn_RoomDelete.Text = "&Delete";
            this.btn_RoomDelete.UseVisualStyleBackColor = true;
            this.btn_RoomDelete.Visible = false;
            this.btn_RoomDelete.Click += new System.EventHandler(this.Btn_RoomDelete_Click);
            // 
            // btn_RoomCancel
            // 
            this.btn_RoomCancel.Location = new System.Drawing.Point(493, 251);
            this.btn_RoomCancel.Name = "btn_RoomCancel";
            this.btn_RoomCancel.Size = new System.Drawing.Size(100, 31);
            this.btn_RoomCancel.TabIndex = 70;
            this.btn_RoomCancel.Text = "&Cancel";
            this.btn_RoomCancel.UseVisualStyleBackColor = true;
            this.btn_RoomCancel.Click += new System.EventHandler(this.Btn_RoomCancel_Click);
            // 
            // dgv_RoomList
            // 
            this.dgv_RoomList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RoomList.GridColor = System.Drawing.Color.White;
            this.dgv_RoomList.Location = new System.Drawing.Point(6, 49);
            this.dgv_RoomList.Name = "dgv_RoomList";
            this.dgv_RoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RoomList.Size = new System.Drawing.Size(587, 196);
            this.dgv_RoomList.TabIndex = 61;
            this.dgv_RoomList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RoomList_CellDoubleClick);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(19, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(102, 24);
            this.Label5.TabIndex = 60;
            this.Label5.Text = "Room List";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 332);
            this.Controls.Add(this.Tab_Room);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoom";
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            this.Tab_Room.ResumeLayout(false);
            this.TabPageNewRoom.ResumeLayout(false);
            this.TabPageNewRoom.PerformLayout();
            this.TabPageRoomList.ResumeLayout(false);
            this.TabPageRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl Tab_Room;
        internal System.Windows.Forms.TabPage TabPageNewRoom;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnRoomSave;
        internal System.Windows.Forms.TextBox txtNoOfOccupancy;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtRoomRate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtRoomType;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRoomNumber;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TabPage TabPageRoomList;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.DataGridView dgv_RoomList;
        internal System.Windows.Forms.Button btn_RoomCancel;
        internal System.Windows.Forms.Button btn_RoomDelete;
    }
}