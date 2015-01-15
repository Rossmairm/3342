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
    public partial class CourseAdd : System.Web.UI.Page
    {
        public void ClearFields()
        {
            txtTitle.Text = "";
            txtDepartmentID.Text = "";
            txtSection.Text = "";
            txtProfessor.Text = "";
            txtDayCode.Text = "";
            txtTimeCode.Text = "";
            txtCreditHours.Text = "";
            txtSeatsAvailable.Text = "";
            txtMaximumSeats.Text = "";


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CourseFunctions operation = new CourseFunctions();

            //checks to make sure that user information fields are not empty
            if (txtTitle.Text == "" || txtDepartmentID.Text == "" || txtSection.Text == "" || txtProfessor.Text == "" || txtDayCode.Text == "" || txtTimeCode.Text == "" || txtCreditHours.Text == "" || txtSeatsAvailable.Text == "" || txtMaximumSeats.Text == "")
            {

                lblOutput.Text = "Please fill out all fields.";
            }
            else
            {
                if (!Regex.IsMatch(txtSection.Text, "^\\d{1,3}$"))//input validation
                {

                    lblOutput.Text = "Invalid Section";
                }
                else
                {
                    if (!Regex.IsMatch(txtMaximumSeats.Text,"^\\d{1,2}$") || !Regex.IsMatch(txtSeatsAvailable.Text, "^\\d{1,2}$"))//input validation
                    {
                        lblOutput.Text = "Invalid seats must be a number";
                    }
                    else
                    {
                        if (!(double.Parse(txtSeatsAvailable.Text) <= double.Parse(txtMaximumSeats.Text)))//input validation
                        {
                            lblOutput.Text = "Invalid available seats must not exceed Maximum Seats";
                        }
                        else
                        {
                            if (!Regex.IsMatch(txtCreditHours.Text, "^\\d{1,1}$"))//input validation
                            {
                                lblOutput.Text = "Invalid credits must be an int";
                            }
                            else
                            {
                                lblOutput.Text = "The CRN is: " + operation.Newcourse(txtTitle.Text, txtDepartmentID.Text, txtSection.Text, txtProfessor.Text, txtDayCode.Text, txtTimeCode.Text, double.Parse(txtCreditHours.Text), int.Parse(txtSeatsAvailable.Text), int.Parse(txtMaximumSeats.Text));
                                ClearFields();

                            }
                        }
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