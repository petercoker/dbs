using System;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.GUIFormRevision
{
    public partial class GUIFormRevision : Form
    {
        public GUIFormRevision()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            BasicTaxCalculator basic = new BasicTaxCalculator();

            basic.FirstName = txtFirstName.Text;
            basic.LastName = txtLastName.Text;
            if (txtStatus.Text.ToLower() == "s")
            {
                basic.Single = true;
            }

            else
            {
                basic.Single = false;
            }
            basic.Salary = double.Parse(txtSalary.Text);

            MessageBox.Show($"{basic.ToString()}\nTax payable is {basic.CalculateIncomeTax()}");
           

        }
    }
}
