using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices;

namespace Project3
{
    public partial class AddClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMain_Click(object sender, EventArgs e)
        {

            Response.Redirect("index.aspx");
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SVC.WebService pxy = new SVC.WebService();

           SVC.Client add = new SVC.Client();
            add.firstName = txtFirstName.Text;
            add.lastName = txtLastName.Text;
            lblDisplay.Text = "The ID is "+pxy.addClient(add);
        }
    }
}