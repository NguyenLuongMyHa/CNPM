namespace HOTELMANAGEMENT
{
    partial class frmCheckin
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
            this.dgvCheckinList = new System.Windows.Forms.DataGridView();
            this.bttnCheckin = new System.Windows.Forms.Button();
            this.bttnCancelReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckinList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckinList
            // 
            this.dgvCheckinList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckinList.GridColor = System.Drawing.Color.White;
            this.dgvCheckinList.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckinList.Name = "dgvCheckinList";
            this.dgvCheckinList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckinList.Size = new System.Drawing.Size(708, 273);
            this.dgvCheckinList.TabIndex = 45;
            this.dgvCheckinList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCheckinList_CellClick);
            // 
            // bttnCheckin
            // 
            this.bttnCheckin.Location = new System.Drawing.Point(490, 292);
            this.bttnCheckin.Name = "bttnCheckin";
            this.bttnCheckin.Size = new System.Drawing.Size(94, 30);
            this.bttnCheckin.TabIndex = 44;
            this.bttnCheckin.Text = "&Checkin";
            this.bttnCheckin.UseVisualStyleBackColor = true;
            this.bttnCheckin.Click += new System.EventHandler(this.BttnCheckin_Click);
            // 
            // bttnCancelReserve
            // 
            this.bttnCancelReserve.Location = new System.Drawing.Point(590, 291);
            this.bttnCancelReserve.Name = "bttnCancelReserve";
            this.bttnCancelReserve.Size = new System.Drawing.Size(130, 30);
            this.bttnCancelReserve.TabIndex = 43;
            this.bttnCancelReserve.Text = "Cancel &Reservation";
            this.bttnCancelReserve.UseVisualStyleBackColor = true;
            this.bttnCancelReserve.Click += new System.EventHandler(this.BttnCancelReserve_Click);
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 331);
            this.Controls.Add(this.dgvCheckinList);
            this.Controls.Add(this.bttnCheckin);
            this.Controls.Add(this.bttnCancelReserve);
            this.Name = "frmCheckin";
            this.Text = "frmCheckin";
            this.Load += new System.EventHandler(this.FrmCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckinList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckinList;
        internal System.Windows.Forms.Button bttnCheckin;
        internal System.Windows.Forms.Button bttnCancelReserve;
    }
}