using System;
using System.Text;

namespace ExerciseWk1
{
    public partial class Ex1Week1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder bf = new StringBuilder();
            string hobbies = "";
            foreach (var item in chkHobbies.Items)
            {
                if (item.Selected == true)
                {
                    hobbies = hobbies + item + "<br />";
                }
            }

            bf.Append("Name: ");
            bf.Append(txtFirstName.Text + "" + txtLastName.Text);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            pnlShow.Visible = false;
        }
    }
}