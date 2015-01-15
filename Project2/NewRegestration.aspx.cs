using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseRegistrationLibrary;
using System.Text.RegularExpressions;


namespace Project2
{
    public partial class NewRegestration : System.Web.UI.Page
    {
        public void ClearFields()
        {
            txtFirstName.Text = "";
            txtCity.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtState.Text = "";
            txtStreet.Text = "";
            txtZip.Text = "";


        }

        public void RemoveText()
        { 
        
            txtFirstName.Visible = false;
            txtCity.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            txtPhone.Visible = false;
            txtState.Visible = false;
            txtStreet.Visible = false;
            txtZip.Visible = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double defaultBal = 0;
            StudentFunctions New = new StudentFunctions();

            //checks to make sure that user information fields are not empty


            if (txtCity.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtState.Text == "" || txtStreet.Text == "" || txtZip.Text == "")
            {

                lblOutput.Text = "Please fill out all fields.";
            }
            else
            {
                if (!Regex.IsMatch(txtPhone.Text, "^\\d{10}$"))//input validation
                {

                    lblOutput.Text = "Invalid phone number";
                }
                else
                {
                    if (!Regex.IsMatch(txtZip.Text, "^\\d{5}$"))//input validation
                    {
                        lblOutput.Text = "Invalid Zip";
                    }
                    else
                    {
                        lblOutput.Text = "Your Student ID is: " + New.NewStudentRegestration(txtFirstName.Text, txtLastName.Text, defaultBal, txtStreet.Text, txtCity.Text, txtState.Text, txtZip.Text, txtPhone.Text);
                        ClearFields();
                      

                        

                    }
                }
            } 
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }


}

