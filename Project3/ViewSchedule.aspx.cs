using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;



namespace Project3
{
    public partial class ViewSchedule : System.Web.UI.Page
    {
       DBConnect objDB = new DBConnect();
        SVC.WebService pxy = new SVC.WebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet table = pxy.getReservations();
                gvOutput.DataSource = table;
                gvOutput.DataBind();
            }

        }


        

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}