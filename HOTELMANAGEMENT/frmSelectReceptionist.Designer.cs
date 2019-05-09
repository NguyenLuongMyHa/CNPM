namespace HOTELMANAGEMENT
{
    partial class frmSelectReceptionist
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
            this.dgvReceptionist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceptionist
            // 
            this.dgvReceptionist.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReceptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReceptionist.Location = new System.Drawing.Point(0, 31);
            this.dgvReceptionist.Margin = new System.Windows.Forms.Padding(10);
            this.dgvReceptionist.Name = "dgvReceptionist";
            this.dgvReceptionist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptionist.Size = new System.Drawing.Size(1033, 407);
            this.dgvReceptionist.TabIndex = 2;
            this.dgvReceptionist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceptionist_CellDoubleClick);
            // 
            // frmSelectReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 438);
            this.Controls.Add(this.dgvReceptionist);
            this.Name = "frmSelectReceptionist";
            this.Text = "frmSelectReceptionist";
            this.Load += new System.EventHandler(this.FrmSelectReceptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceptionist;
    }
}