using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServices;


namespace Project3
{
    public partial class AddHome : System.Web.UI.Page
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
            //makes sure they are not blank
            int Price;
            int bedrooms;
            double bathrooms;
            int SF;

            SVC.WebService pxy = new SVC.WebService();
            
            SVC.Home home = new SVC.Home();

            if (txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtAddress.Text == "" || txtSquareFootage.Text == "" || lblBedroom.Text == "" || txtBathroom.Text == "")
            {
                lblDisplay.Text = "Please fill out all fields.";
            }
            else
            {

                if (!(int.TryParse(txtPrice.Text, out Price)))//input validation
                {
                    lblDisplay.Text = "Invalid price must be an int";
                }
                else
                {

                    if (!(int.TryParse(txtBedroom.Text, out bedrooms)))//input validation
                    {
                        lblDisplay.Text = "Invalid bedrooms must be an int";
                    }
                    else
                    {
                        if (!(double.TryParse(txtBathroom.Text, out bathrooms)))//input validation
                        {
                            lblDisplay.Text = "Invaild Bathrooms must be a number";
                        }
                        else
                        {
                            if (!(int.TryParse(txtSquareFootage.Text, out SF)))//input validation
                            {
                                lblDisplay.Text = "Invalid Square footage must be an int";
                            }
                            else
                            {

                                home.address = txtAddress.Text;
                                home.city = txtCity.Text;
                                home.state = txtState.Text;
                                home.price = Price;
                                home.SF = SF;
                                home.availability = ddAvailability.SelectedValue;
                                home.bedrooms = bedrooms;
                                home.bathrooms = bathrooms;
                                home.Type = ddType.SelectedValue;

                                lblDisplay.Text ="The ID number is "+pxy.addHome(home);




                            }
                        }
                    }
                }
            }
        }
    }
}