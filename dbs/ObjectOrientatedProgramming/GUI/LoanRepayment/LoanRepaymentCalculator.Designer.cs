namespace dbs.ObjectOrientatedProgramming.GUI.LoanRepayment
{
    partial class LoanRepaymentCalculator
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
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtTem = new System.Windows.Forms.TextBox();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(13, 70);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(105, 20);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Loan Amount";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(81, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Loan Repayment Calculator";
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(13, 102);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(42, 20);
            this.lblAPR.TabIndex = 2;
            this.lblAPR.Text = "APR";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(13, 135);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(45, 20);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "Term";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(157, 63);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(161, 26);
            this.txtLoan.TabIndex = 4;
            this.txtLoan.TextChanged += new System.EventHandler(this.txtLoan_TextChanged);
            // 
            // txtTem
            // 
            this.txtTem.Location = new System.Drawing.Point(157, 135);
            this.txtTem.Name = "txtTem";
            this.txtTem.Size = new System.Drawing.Size(161, 26);
            this.txtTem.TabIndex = 5;
            this.txtTem.TextChanged += new System.EventHandler(this.txtTem_TextChanged);
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(157, 99);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(161, 26);
            this.txtAPR.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(157, 180);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(161, 58);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(11, 278);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // LoanRepaymentCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 347);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAPR);
            this.Controls.Add(this.txtTem);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblAPR);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoan);
            this.Name = "LoanRepaymentCalculator";
            this.Text = "LoanRepaymentCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtTem;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
    }
}