using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
  

    public partial class LabDemo : System.Web.UI.Page
    {
        int count = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           count++;
             lbl1.Text = "dogs" + txtName.Text + "count = "+ count;
        }
    }
}