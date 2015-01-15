using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;


namespace Project3
{
    public partial class SearchRegister : System.Web.UI.Page
    {
        ArrayList Visit = new ArrayList();

        SVC.WebService pxy = new SVC.WebService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet table = pxy.pullSet();
                gvHomes.DataSource = table;
                gvHomes.DataBind();
             
                         }
            

        }

        protected void gvHomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rowIndex = gvHomes.SelectedRow.Cells[1].Text;


          

        }

        protected void btnCityState_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtState.Text == "")
            {
                lblDisplay.Text = "Must have City and State";
            }
            else
            {
                DataSet search = pxy.HomeSearch(txtCity.Text, txtState.Text);
                gvHomes.DataSource = search;
                gvHomes.DataBind();

            }
        }
        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");

        }

        protected void btnMax_Click(object sender, EventArgs e)
        {
            int max;
            if (txtCity.Text == "" || txtState.Text == "")
            {
                lblDisplay.Text = "Must have City and State";
            }
            else
            {
                if (!(int.TryParse(txtPrice.Text, out max)))
                {
                    lblDisplay.Text = "incorrect price format";
                }
                else
                {
                    DataSet search = pxy.MaxSearch(txtCity.Text, txtState.Text, max);
                    gvHomes.DataSource = search;
                    gvHomes.DataBind();
                }

            }
        }

        protected void btnSize_Click(object sender, EventArgs e)
        {
            int size;
            if (txtCity.Text == "" || txtState.Text == "")
            {
                lblDisplay.Text = "Must have City and State";
            }
            else
            {

                if (!(int.TryParse(txtSize.Text, out size)))
                {
                    lblDisplay.Text = "incorrect price format";
                }
                else
                {
                    DataSet search = pxy.SizeSearch(txtCity.Text, txtState.Text, size);
                    gvHomes.DataSource = search;
                    gvHomes.DataBind();
                }
            }
        }
        protected void btnType_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtState.Text == "")
            {
                lblDisplay.Text = "Must have City and State";
            }
            else
            {
                DataSet search = pxy.TypeSearch(txtCity.Text, txtState.Text, ddType.SelectedValue);

                gvHomes.DataSource = search;
                gvHomes.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int homeID;
            int clientID= int.Parse(ddClient.SelectedValue);
            int realtorID = int.Parse(ddRealtor.SelectedValue);
            for (int i = 0; i < gvHomes.Rows.Count; i++)
            { 
                CheckBox checker = (CheckBox)gvHomes.Rows[i].FindControl("ckRegister");
                if (checker.Checked)
                {
                    homeID = int.Parse(gvHomes.Rows[i].Cells[1].Text);
                   lblDisplay.Text= pxy.Booking(homeID, clientID, realtorID);

                }


            }
        }
    }
}