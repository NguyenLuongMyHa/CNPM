namespace HOTELMANAGEMENT
{
    partial class frmCheckout
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
            this.dgvCheckoutList = new System.Windows.Forms.DataGridView();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckoutList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckoutList
            // 
            this.dgvCheckoutList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckoutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckoutList.GridColor = System.Drawing.Color.White;
            this.dgvCheckoutList.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckoutList.Name = "dgvCheckoutList";
            this.dgvCheckoutList.Size = new System.Drawing.Size(708, 273);
            this.dgvCheckoutList.TabIndex = 48;
            this.dgvCheckoutList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCheckoutList_CellClick);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(626, 292);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(94, 30);
            this.btnCheckout.TabIndex = 47;
            this.btnCheckout.Text = "&Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 334);
            this.Controls.Add(this.dgvCheckoutList);
            this.Controls.Add(this.btnCheckout);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckoutList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckoutList;
        internal System.Windows.Forms.Button btnCheckout;
    }
}