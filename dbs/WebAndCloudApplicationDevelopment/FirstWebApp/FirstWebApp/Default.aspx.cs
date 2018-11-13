using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnBack.Visible = false;
            }

            else 
            {
                pnlInfo.Visible = false;
                btnBack.Visible = true;
            }
        }

        protected void btClick_Click(object sender, EventArgs e)
        {
            Response.Write("Your name is: " +txtName.Text);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;
            btnBack.Visible = false;
        }
    }
}