using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using CourseRegistrationLibrary;
using System.Collections;
using System.Data;

namespace Project2
{
    public partial class StudentRoster : System.Web.UI.Page
    {
        CouseRegistration function = new CouseRegistration();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet Searched = function.Roster(txtStudentID.Text);
            gvRoster.DataSource = Searched;
            gvRoster.DataBind();
           
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}