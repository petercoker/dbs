using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.EmployeePromotion
{
    public partial class EmployeePromotionQuery : Form
    {
        public EmployeePromotionQuery()
        {
            InitializeComponent();
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtName, string.Empty);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                epError.SetError(txtName, "You must enter your name");

                cancel = true;
            }

            e.Cancel = cancel;
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            int year = 0;

            if (int.TryParse(txtYear.Text, out year))
            {
                epError.SetError(txtYear, "Must be a year, number value");
            }

            e.Cancel = cancel;
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtYear, string.Empty);
        }

        private void txtPosition_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            int position = 0;

            if (int.TryParse(txtPosition.Text, out position))
            {
                if (position > 5 || position < 0)
                {
                    epError.SetError(txtPosition, "You can only choose from 1 to 5");
                    cancel = true;
                }

            }
            else
            {
              epError.SetError(txtPosition, "You must enter a number");
                cancel = true;
            }

            e.Cancel = cancel;
        }

        private void txtPosition_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtPosition, string.Empty);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.Name = txtName.Text;
            employee.YearsWorked = int.Parse(txtYear.Text);
            employee.PositionPoint = int.Parse(txtPosition.Text);

            lblInfo.Text = employee.ToString();

            bool promo = employee.Promotion();

            if (employee.Promotion()) //if is already a bool 
            {
                MessageBox.Show($"{employee.Name} is eligible for a promotion");
            }

            else
            {
                MessageBox.Show($"{employee.Name} is not eligible for a promotion");
            }

            //Alternative way
            //if (promo)
            //{
            //    MessageBox.Show($"{employee.Name} is eligible for a promotion");
            //}

            //else
            //{
            //    MessageBox.Show($"{employee.Name} is not eligible for a promotion");
            //}
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
