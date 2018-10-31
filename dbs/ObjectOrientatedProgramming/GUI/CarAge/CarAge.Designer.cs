namespace dbs.ObjectOrientatedProgramming.GUI.CarAge
{
    partial class CarAge
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
            this.lblMake = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(72, 104);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(48, 20);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            this.lblMake.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(72, 150);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(55, 20);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "Colour";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(72, 189);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(185, 97);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(138, 26);
            this.txtMake.TabIndex = 3;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(185, 189);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 26);
            this.txtYear.TabIndex = 4;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(185, 147);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(138, 26);
            this.txtColour.TabIndex = 5;
            this.txtColour.TextChanged += new System.EventHandler(this.txtColour_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(71, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Car Age Form";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(185, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 36);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Age";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(76, 239);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 8;
            // 
            // CarAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 315);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblMake);
            this.Name = "CarAge";
            this.Text = "CarAge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInfo;
    }
}