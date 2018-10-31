using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.ValidatingExample
{
    public partial class ValidatingExample : Form
    {
        public ValidatingExample()
        {
            InitializeComponent();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            //check if the textbook is empty

            if (string.IsNullOrEmpty(txtName.Text))
            {
                epError.SetError(txtName, "Must have a value");
                cancel = true;
            }

            e.Cancel = cancel;
        }
        private void txtName_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtName, string.Empty);
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            int age = 0;

            //Is it a number?
            if (int.TryParse(txtAge.Text, out age))
            {
                //Check is it in range?
                if (age < 0 || age > 100)
                {
                    epError.SetError(txtAge, "Must be between 1-100");
                    cancel = true;
                }

            }

            else
            {
                epError.SetError(txtAge, "Must be number value, not text");
                cancel = true;
            }

            e.Cancel = cancel;
        }

        private void txtAge_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtAge, string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Saved");
            }
        }
    }
}
