using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.CarAge
{
    public partial class CarAge : Form
    {
        public CarAge()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColour_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string make, colour;
            int year;

            make = txtMake.Text;
            colour = txtColour.Text;
            year = int.Parse(txtYear.Text);

            int age = DateTime.Now.Year - year;

            lblInfo.Text = $"Your Car is a {make} that is " + $"{colour} and is {age} years old";
            MessageBox.Show($"{make}\n{colour}\n{age} years old");
        }
    }
}
