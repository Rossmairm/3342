using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using PizzaLibrary;

namespace Project1
{
    public partial class MyPizzaShop : System.Web.UI.Page
    {
        
        protected Class1 pizzadb;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pizzadb = new Class1();
            }
            {
                DBConnect objDB = new DBConnect();
                string strSQL = "SELECT * FROM Pizzas";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvPizzas.DataSource = myDS;
                gvPizzas.DataBind();
                gvPizzas0.DataSource = myDS;
                gvPizzas0.DataBind();
              
                objDB.CloseConnection();

            }
        }

        protected void GVPizzaDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            gvPizzas.Visible = false;
            gvPizzas0.Visible = true;
            CheckBox checker;
            string type;
            double size;
            int quanity;


            if (txtCity.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtState.Text == "" || txtStreet.Text == "" || txtZip.Text == "")
            {


            }
            else
            {
                for (int i=0; i>gvPizzas.Rows.Count; i++)
                {
                    checker = (CheckBox)gvPizzas.Rows[i].FindControl("chkPizza");
                    if (checker.Checked)
                    {
                        type = gvPizzas.Rows[i].Cells[1].Text;
                    //    size=namespace gvPizzas.Rows[i].FindControl("ddlSize")

                    }
                }
            }
        }

        protected void rbPickup_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void rbDeliver_CheckedChanged(object sender, EventArgs e)
        {
       

        }

        protected void gvPizzas0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvPizzas0_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}