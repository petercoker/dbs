using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.LoanRepayment
{
    public partial class LoanRepaymentCalculator : Form
    {
        public LoanRepaymentCalculator()
        {
            InitializeComponent();
        }

        private void txtLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            LoanRepayment repayment = new LoanRepayment();

            repayment.LoanAmount = double.Parse(txtLoan.Text);
            repayment.APR = double.Parse(txtAPR.Text);
            repayment.Term = double.Parse(txtTem.Text);

            MessageBox.Show($"Monthly Replayment is {repayment.CalculateMonthly()}");

            lblTotal.Text = $"Total Interestert on the loan is {repayment.TotalInterest(repayment.CalculateMonthly())}"; //Here we are calling a method within a method
        }
    }
}
