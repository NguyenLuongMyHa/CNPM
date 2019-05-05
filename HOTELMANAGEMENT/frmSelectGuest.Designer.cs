namespace HOTELMANAGEMENT
{
    partial class frmSelectGuest
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
            this.dgvGuest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuest
            // 
            this.dgvGuest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGuest.Location = new System.Drawing.Point(0, 30);
            this.dgvGuest.Margin = new System.Windows.Forms.Padding(10);
            this.dgvGuest.Name = "dgvGuest";
            this.dgvGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuest.Size = new System.Drawing.Size(1034, 414);
            this.dgvGuest.TabIndex = 1;
            this.dgvGuest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGuest_CellDoubleClick);
            // 
            // frmSelectGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1034, 444);
            this.Controls.Add(this.dgvGuest);
            this.Name = "frmSelectGuest";
            this.Text = " Double click to select guest";
            this.Load += new System.EventHandler(this.FrmSelectGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuest;
    }
}

