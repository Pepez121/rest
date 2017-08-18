namespace Vendors
{
    partial class VendorsForm
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
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorEmail = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvVendors = new System.Windows.Forms.DataGridView();
            this.lblFindVendor = new System.Windows.Forms.Label();
            this.txtFindVendor = new System.Windows.Forms.TextBox();
            this.btnFindVendor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorName.Location = new System.Drawing.Point(12, 38);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(125, 22);
            this.lblVendorName.TabIndex = 0;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorEmail
            // 
            this.lblVendorEmail.AutoSize = true;
            this.lblVendorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorEmail.Location = new System.Drawing.Point(15, 85);
            this.lblVendorEmail.Name = "lblVendorEmail";
            this.lblVendorEmail.Size = new System.Drawing.Size(122, 22);
            this.lblVendorEmail.TabIndex = 1;
            this.lblVendorEmail.Text = "Vendor Email:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.Location = new System.Drawing.Point(168, 35);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(219, 27);
            this.txtVendorName.TabIndex = 2;
            // 
            // txtVendorEmail
            // 
            this.txtVendorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorEmail.Location = new System.Drawing.Point(168, 82);
            this.txtVendorEmail.Name = "txtVendorEmail";
            this.txtVendorEmail.Size = new System.Drawing.Size(219, 27);
            this.txtVendorEmail.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(323, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(323, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvVendors
            // 
            this.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendors.Location = new System.Drawing.Point(28, 144);
            this.dgvVendors.Name = "dgvVendors";
            this.dgvVendors.Size = new System.Drawing.Size(254, 144);
            this.dgvVendors.TabIndex = 7;
            // 
            // lblFindVendor
            // 
            this.lblFindVendor.AutoSize = true;
            this.lblFindVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindVendor.Location = new System.Drawing.Point(73, 332);
            this.lblFindVendor.Name = "lblFindVendor";
            this.lblFindVendor.Size = new System.Drawing.Size(178, 22);
            this.lblFindVendor.TabIndex = 8;
            this.lblFindVendor.Text = "Find Vendor\'s Name:";
            this.lblFindVendor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFindVendor
            // 
            this.txtFindVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindVendor.Location = new System.Drawing.Point(77, 366);
            this.txtFindVendor.Name = "txtFindVendor";
            this.txtFindVendor.Size = new System.Drawing.Size(174, 27);
            this.txtFindVendor.TabIndex = 9;
            // 
            // btnFindVendor
            // 
            this.btnFindVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindVendor.Location = new System.Drawing.Point(277, 358);
            this.btnFindVendor.Name = "btnFindVendor";
            this.btnFindVendor.Size = new System.Drawing.Size(99, 43);
            this.btnFindVendor.TabIndex = 10;
            this.btnFindVendor.Text = "Find";
            this.btnFindVendor.UseVisualStyleBackColor = true;
            this.btnFindVendor.Click += new System.EventHandler(this.btnFindVendor_Click);
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 420);
            this.Controls.Add(this.btnFindVendor);
            this.Controls.Add(this.txtFindVendor);
            this.Controls.Add(this.lblFindVendor);
            this.Controls.Add(this.dgvVendors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVendorEmail);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblVendorEmail);
            this.Controls.Add(this.lblVendorName);
            this.Name = "VendorsForm";
            this.Text = "Vendors Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorEmail;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvVendors;
        private System.Windows.Forms.Label lblFindVendor;
        private System.Windows.Forms.TextBox txtFindVendor;
        private System.Windows.Forms.Button btnFindVendor;
    }
}

