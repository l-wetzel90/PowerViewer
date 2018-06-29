namespace Program1
{
    partial class frmPower
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
            this.lblPerKwh = new System.Windows.Forms.Label();
            this.lblWattage = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.txtPerHour = new System.Windows.Forms.TextBox();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.txtPerYear = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlAppliences = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblPerKwh
            // 
            this.lblPerKwh.AutoSize = true;
            this.lblPerKwh.Location = new System.Drawing.Point(37, 55);
            this.lblPerKwh.Name = "lblPerKwh";
            this.lblPerKwh.Size = new System.Drawing.Size(75, 13);
            this.lblPerKwh.TabIndex = 1;
            this.lblPerKwh.Text = "Price per kWh";
            // 
            // lblWattage
            // 
            this.lblWattage.AutoSize = true;
            this.lblWattage.Location = new System.Drawing.Point(37, 105);
            this.lblWattage.Name = "lblWattage";
            this.lblWattage.Size = new System.Drawing.Size(85, 13);
            this.lblWattage.TabIndex = 2;
            this.lblWattage.Text = "Current Wattage";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(355, 55);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(72, 13);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Cost per Hour";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(355, 120);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(68, 13);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Cost per Day";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(355, 193);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Cost per year";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(128, 98);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 7;
            // 
            // txtKwh
            // 
            this.txtKwh.Location = new System.Drawing.Point(114, 48);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(100, 20);
            this.txtKwh.TabIndex = 6;
            // 
            // txtPerHour
            // 
            this.txtPerHour.Location = new System.Drawing.Point(430, 48);
            this.txtPerHour.Name = "txtPerHour";
            this.txtPerHour.Size = new System.Drawing.Size(100, 20);
            this.txtPerHour.TabIndex = 8;
            // 
            // txtPerDay
            // 
            this.txtPerDay.Location = new System.Drawing.Point(430, 113);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(100, 20);
            this.txtPerDay.TabIndex = 9;
            // 
            // txtPerYear
            // 
            this.txtPerYear.Location = new System.Drawing.Point(430, 186);
            this.txtPerYear.Name = "txtPerYear";
            this.txtPerYear.Size = new System.Drawing.Size(100, 20);
            this.txtPerYear.TabIndex = 10;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(36, 230);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(197, 20);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Devices we can turn off";
            // 
            // pnlAppliences
            // 
            this.pnlAppliences.Location = new System.Drawing.Point(40, 253);
            this.pnlAppliences.Name = "pnlAppliences";
            this.pnlAppliences.Size = new System.Drawing.Size(490, 191);
            this.pnlAppliences.TabIndex = 13;
            // 
            // frmPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 474);
            this.Controls.Add(this.pnlAppliences);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtPerYear);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.txtPerHour);
            this.Controls.Add(this.txtKwh);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblWattage);
            this.Controls.Add(this.lblPerKwh);
            this.Name = "frmPower";
            this.Text = "Power Viewer";
            this.Load += new System.EventHandler(this.frmPower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerKwh;
        private System.Windows.Forms.Label lblWattage;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.TextBox txtPerHour;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.TextBox txtPerYear;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.FlowLayoutPanel pnlAppliences;
    }
}

