using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRegestration.aspx");
        }

        protected void btnReturningStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("Returning.aspx");
        }

        protected void btnCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseAdd.aspx");
        }

        protected void btnCourseEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseEdit.aspx");
        }

        protected void btnEditStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentRoster.aspx");
        }
    }
}