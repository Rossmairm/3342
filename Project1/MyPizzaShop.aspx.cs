using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using PizzaLibrary;
using System.Collections;
using System.Text.RegularExpressions;





namespace Project1
{
    public partial class MyPizzaShop : System.Web.UI.Page
    {

        protected Class1 pizzadb;
        PizzaFunctions function = new PizzaFunctions();

        ArrayList pizzaOrders = new ArrayList();




        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //filling grid view with information from the database
                DBConnect objDB = new DBConnect();
                string strSQL = "SELECT * FROM Pizzas";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvPizzas.DataSource = myDS;
                gvPizzas.DataBind();

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
            //creating variables for data collection from ordering gridview
            CheckBox checker;
            DropDownList ddlSize;
            TextBox txtPizza;
            double size;
            string type;
            int quantity;
            double totalSales = 0;
            int totalQuantity = 0;


            //checks to make sure that user information fields are not empty
            if (txtCity.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtState.Text == "" || txtStreet.Text == "" || txtZip.Text == "")
            {

                lblError.Text = "Please fill out all fields.";
            }
            else
            {
                if (!Regex.IsMatch(txtPhone.Text, "\\d{10}"))//input validation
                {

                    lblError.Text = "Invalid phone number";
                }
                else
                {
                    if (!Regex.IsMatch(txtZip.Text, "\\d{5}"))//input validation
                    {
                        lblError.Text = "Invalid Zip";
                    }
                    else
                    {
                        if (!(rbDeliver.Checked || rbPickup.Checked))//input validation
                        {
                            lblError.Text = "Select Delivery or Pickup";

                        }
                        else
                        {
                            for (int i = 0; i < gvPizzas.Rows.Count; i++)
                            {
                                Pizza PizzaObject = new Pizza();
                                checker = (CheckBox)gvPizzas.Rows[i].FindControl("chkPizza");
                                if (checker.Checked)
                                {
                                    //collects information from the gridview
                                    type = gvPizzas.Rows[i].Cells[1].Text;
                                    ddlSize = (DropDownList)gvPizzas.Rows[i].FindControl("ddlSize");
                                    txtPizza = (TextBox)gvPizzas.Rows[i].FindControl("txtQuantity");
                                    if (int.TryParse(txtPizza.Text, out quantity) == false)
                                    {
                                        lblError.Text = "plase enter a valid amount";
                                    }
                                    else
                                    {


                                        if (ddlSize.SelectedValue == "Select")//input validation
                                        {
                                            lblError.Text = "size not selected";
                                        }
                                        else
                                        {
                                            // fills the pizza object so an order can be created
                                            size = function.SizeFinder(ddlSize.SelectedValue);
                                            PizzaObject.Size = size;
                                            PizzaObject.PizzaType = type;
                                            PizzaObject.Quantity = quantity;
                                            PizzaObject.Price = size * function.PriceFinder(type);
                                            PizzaObject.TotalCost = quantity * PizzaObject.Price;

                                            function.updateTotals(PizzaObject.PizzaType, PizzaObject.Quantity, PizzaObject.Price);
                                            //adds pizza to the order list
                                            pizzaOrders.Add(PizzaObject);

                                            gvPizzas.Visible = false;
                                            gvOutput.Visible = true;
                                            gvManager.Visible = false;
                                            lblError.Text = "";

                                        }



                                    }

                                }




                                gvOutput.DataSource = pizzaOrders;
                                gvOutput.DataBind();
                                for (int j = 0; j < gvOutput.Rows.Count; j++)
                                {
                                    totalSales += double.Parse(gvOutput.Rows[j].Cells[4].Text);
                                    totalQuantity += int.Parse(gvOutput.Rows[j].Cells[1].Text);


                                }
                                
                                gvOutput.Columns[0].FooterText = "Totals:";
                                gvOutput.Columns[1].FooterText = totalQuantity.ToString();
                                gvOutput.Columns[2].FooterText = "";
                                gvOutput.Columns[3].FooterText = function.returnSales("Cheese").ToString();
                                gvOutput.Columns[4].FooterText = totalSales.ToString();

                                lblOutput.Text = "Customer information:" + "<br />" + txtFirstName.Text + " " + txtLastName.Text + "<br />" + txtStreet.Text + "<br />" + txtCity.Text + ", " + txtState.Text + " " + txtZip.Text;

                            }


                        }


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

        protected void btnReport_Click(object sender, EventArgs e)
        {
            gvPizzas.Visible = false;
            gvOutput.Visible = false;
            gvManager.Visible = true;
            btnSubmit.Visible = false;

            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Pizzas";
            DataSet myDS = objDB.GetDataSet(strSQL);
            gvManager.DataSource = myDS;
            gvManager.DataBind();
            objDB.CloseConnection();

        }
    }
}