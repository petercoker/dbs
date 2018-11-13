using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.YearGrad
{
    public partial class YearGrad : Form
    {
        public YearGrad()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Info Saved");
            }
        }
        private void txtCourse_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            //check if the textbook is empty

            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                epError.SetError(txtCourse, "You must enter a course");
                cancel = true;
            }

            e.Cancel = cancel;
        }

        private void txtCourse_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtCourse, string.Empty);
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            int year = 0;
            
            if(int.TryParse(txtYear.Text, out year))
            {
                if (year < 2018)
                {
                    epError.SetError(txtYear, "Cannot Graduate in the past");
                    cancel = true;
                }
            }

            else
            {
                epError.SetError(txtYear, "Must be a year, number value");
            }
            e.Cancel = cancel;
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtYear, string.Empty);
        }
    }
}
