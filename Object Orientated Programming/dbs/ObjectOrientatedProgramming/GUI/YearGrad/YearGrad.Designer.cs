namespace dbs.ObjectOrientatedProgramming.GUI.YearGrad
{
    partial class YearGrad
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
            this.components = new System.ComponentModel.Container();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(32, 66);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(106, 20);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course Name";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(36, 125);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(127, 20);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year Graduating";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(214, 59);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(185, 26);
            this.txtCourse.TabIndex = 2;
            this.txtCourse.Validating += new System.ComponentModel.CancelEventHandler(this.txtCourse_Validating);
            this.txtCourse.Validated += new System.EventHandler(this.txtCourse_Validated);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(214, 118);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(185, 26);
            this.txtYear.TabIndex = 3;
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // YearGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCourse);
            this.Name = "YearGrad";
            this.Text = "YearGrad";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epError;
    }
}