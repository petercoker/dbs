using System;

namespace dbs.ObjectOrientatedProgramming.GUI.LoanRepayment
{
    class LoanRepayment
    {
        public double LoanAmount { get; set; }
        public double APR { get; set; }
        public double Term { get; set; }

        public LoanRepayment()
        {

        }

        public LoanRepayment(double loanAmount, double apr, double tem)
        {
            LoanAmount = loanAmount;
            APR = apr;
            Term = tem;
        }

        public override string ToString()
        {
            return $"You are taking out a {LoanAmount} over {Term}"; 
        }

        public double CalculateMonthly()
        {
            double monthlyAmount, topline, bottomline;

            topline = LoanAmount * (APR / 12);
            bottomline = 1 - Math.Pow(1 + (APR / 12), -12 * Term); // the "," add the the to the power -12 * Term
            monthlyAmount = topline / bottomline;

            return monthlyAmount;
        }

        //If you want to calculate the total interest over the whole loan 
        public double TotalInterest(double repayment)
        {
            double interest;

            interest = ((repayment * 12 * Term) - LoanAmount);

            return interest;
        }
    }
}
