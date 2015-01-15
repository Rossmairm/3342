using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditHomes.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchRegister.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddHome.aspx");
        }

        protected void btnAddClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddClient.aspx");
        }

        protected void btnSchedule_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSchedule.aspx");
        }
    }
}