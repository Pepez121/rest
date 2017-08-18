namespace Miles
{
    partial class Miles
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnTotalMiles = new System.Windows.Forms.Button();
            this.lblStarting = new System.Windows.Forms.Label();
            this.lblEnding = new System.Windows.Forms.Label();
            this.lblAmountOwed = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.numStarting = new System.Windows.Forms.NumericUpDown();
            this.numEnding = new System.Windows.Forms.NumericUpDown();
            this.radioAirplane = new System.Windows.Forms.RadioButton();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.lblVehicleType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStarting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnding)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(82, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTotalMiles
            // 
            this.btnTotalMiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTotalMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalMiles.Location = new System.Drawing.Point(272, 220);
            this.btnTotalMiles.Name = "btnTotalMiles";
            this.btnTotalMiles.Size = new System.Drawing.Size(124, 42);
            this.btnTotalMiles.TabIndex = 1;
            this.btnTotalMiles.Text = "Display";
            this.btnTotalMiles.UseVisualStyleBackColor = false;
            this.btnTotalMiles.Click += new System.EventHandler(this.btnTotalMiles_Click);
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarting.Location = new System.Drawing.Point(94, 40);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(105, 20);
            this.lblStarting.TabIndex = 2;
            this.lblStarting.Text = "Starting Miles";
            this.lblStarting.Click += new System.EventHandler(this.lblInitial_Click);
            // 
            // lblEnding
            // 
            this.lblEnding.AutoSize = true;
            this.lblEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnding.Location = new System.Drawing.Point(100, 76);
            this.lblEnding.Name = "lblEnding";
            this.lblEnding.Size = new System.Drawing.Size(99, 20);
            this.lblEnding.TabIndex = 3;
            this.lblEnding.Text = "Ending Miles";
            // 
            // lblAmountOwed
            // 
            this.lblAmountOwed.AutoSize = true;
            this.lblAmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOwed.Location = new System.Drawing.Point(78, 178);
            this.lblAmountOwed.Name = "lblAmountOwed";
            this.lblAmountOwed.Size = new System.Drawing.Size(121, 20);
            this.lblAmountOwed.TabIndex = 6;
            this.lblAmountOwed.Text = "Amount Owed";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.Green;
            this.lblTotalMoney.Location = new System.Drawing.Point(268, 178);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(39, 20);
            this.lblTotalMoney.TabIndex = 7;
            this.lblTotalMoney.Text = "$$$";
            this.lblTotalMoney.Click += new System.EventHandler(this.label1_Click);
            // 
            // numStarting
            // 
            this.numStarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStarting.Location = new System.Drawing.Point(272, 38);
            this.numStarting.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStarting.Name = "numStarting";
            this.numStarting.Size = new System.Drawing.Size(136, 26);
            this.numStarting.TabIndex = 8;
            // 
            // numEnding
            // 
            this.numEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEnding.Location = new System.Drawing.Point(272, 74);
            this.numEnding.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEnding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEnding.Name = "numEnding";
            this.numEnding.Size = new System.Drawing.Size(136, 26);
            this.numEnding.TabIndex = 9;
            this.numEnding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioAirplane
            // 
            this.radioAirplane.AutoSize = true;
            this.radioAirplane.Location = new System.Drawing.Point(272, 118);
            this.radioAirplane.Name = "radioAirplane";
            this.radioAirplane.Size = new System.Drawing.Size(63, 17);
            this.radioAirplane.TabIndex = 10;
            this.radioAirplane.TabStop = true;
            this.radioAirplane.Text = "Airplane";
            this.radioAirplane.UseVisualStyleBackColor = true;
            this.radioAirplane.CheckedChanged += new System.EventHandler(this.radioVehicle_CheckedChanged);
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(272, 141);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(41, 17);
            this.radioCar.TabIndex = 11;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Car";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(107, 129);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(99, 20);
            this.lblVehicleType.TabIndex = 12;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // Miles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(476, 286);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.radioCar);
            this.Controls.Add(this.radioAirplane);
            this.Controls.Add(this.numEnding);
            this.Controls.Add(this.numStarting);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblAmountOwed);
            this.Controls.Add(this.lblEnding);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.btnTotalMiles);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Miles";
            this.Text = "Miles Calculation";
            this.Load += new System.EventHandler(this.Miles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStarting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnTotalMiles;
        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.Label lblEnding;
        private System.Windows.Forms.Label lblAmountOwed;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.NumericUpDown numStarting;
        private System.Windows.Forms.NumericUpDown numEnding;
        private System.Windows.Forms.RadioButton radioAirplane;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.Label lblVehicleType;
    }
}

