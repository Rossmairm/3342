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
using System.Text.RegularExpressions;




namespace Project2
{
    public partial class CourseEdit : System.Web.UI.Page
    {

        CourseFunctions function = new CourseFunctions();
        DBConnect objDB = new DBConnect();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                ShowProducts();
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet Searched = function.CourseSearch(ddlType.SelectedValue, txtKeyword.Text);

            gvCourses.DataSource = Searched;
            gvCourses.DataBind();

        }
        protected void gvCourses_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;


            string CRN = gvCourses.Rows[rowIndex].Cells[0].Text;
            
            TextBox Title;//creates text box
            Title = (TextBox)gvCourses.Rows[rowIndex].Cells[1].Controls[0];//adds the info to the text box
            string title = Title.Text;//appends to a string

            TextBox Department;
            Department = (TextBox)gvCourses.Rows[rowIndex].Cells[2].Controls[0];
            string department = Department.Text;

            TextBox Section;
            Section = (TextBox)gvCourses.Rows[rowIndex].Cells[3].Controls[0];
            string section = Section.Text;


            TextBox Professor;
            Professor = (TextBox)gvCourses.Rows[rowIndex].Cells[4].Controls[0];
            string professor = Professor.Text;

            TextBox DayCode;
            DayCode = (TextBox)gvCourses.Rows[rowIndex].Cells[5].Controls[0];
            string dayCode = DayCode.Text;

            TextBox TimeCode;
            TimeCode = (TextBox)gvCourses.Rows[rowIndex].Cells[6].Controls[0];
            string timeCode = TimeCode.Text;

            TextBox CreditHours;
            CreditHours = (TextBox)gvCourses.Rows[rowIndex].Cells[7].Controls[0];
            string creditHours = CreditHours.Text;

            TextBox SeatsAvailable;
            SeatsAvailable = (TextBox)gvCourses.Rows[rowIndex].Cells[8].Controls[0];
            string seatsAvailable = SeatsAvailable.Text;

            TextBox MaximumSeats;
            MaximumSeats = (TextBox)gvCourses.Rows[rowIndex].Cells[9].Controls[0];
            string maximumSeats = MaximumSeats.Text;

            //makes sure they are not blank

            if (title == "" || department == "" || section == "" || professor == "" || dayCode == "" || timeCode == "" || creditHours == "" || seatsAvailable == "" || maximumSeats == "")
            {
                lblDisplay.Text = "Please fill out all fields.";
            }
            else
            {
                if (!Regex.IsMatch(section, "^\\d{1,3}$"))//input validation
                {

                    lblDisplay.Text = "Invalid Section";
                }
                else
                {
                    if (!Regex.IsMatch(maximumSeats, "^\\d{1,2}$") || !Regex.IsMatch(seatsAvailable, "^\\d{1,2}$"))//input validation
                    {
                        lblDisplay.Text = "Invalid seats must be a number";
                    }
                    else
                    {
                        if (!(double.Parse(seatsAvailable) <= double.Parse(maximumSeats)))//input validation
                        {
                            lblDisplay.Text = "Invalid available seats must not exceed Maximum Seats";
                        }
                        else
                        {
                            if (!Regex.IsMatch(creditHours, "^\\d{1,1}$"))//input validation
                            {
                                lblDisplay.Text = "Invalid credits must be an int";
                            }
                            else
                            {
                                double credit = double.Parse(creditHours);
                                int seats = int.Parse(seatsAvailable);
                                int max = int.Parse(maximumSeats);
                                lblDisplay.Text = function.UpdateCourse(CRN, title, department, section, professor, dayCode, timeCode, credit, seats, max);

                                // Set the GridView back to the original state.
                                // No rows currently being edited.
                                gvCourses.EditIndex = -1;
                                ShowProducts();

                            }
                        }
                    }
                }
            }
        }

        protected void gvCourses_RowEditing(Object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            // Set the row to edit-mode in the GridView
            gvCourses.EditIndex = e.NewEditIndex;
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Course";
            DataSet myDS = objDB.GetDataSet(strSQL);



            gvCourses.DataSource = myDS;
            gvCourses.DataBind();
            lblDisplay.Text = "";
        }

        protected void gvCourses_RowDeleteing(Object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string CRN = gvCourses.Rows[rowIndex].Cells[0].Text;
            function.DeleteEntry(CRN);
            gvCourses.DataBind();
            ShowProducts();

        }
        protected void gvCourses_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state
            // No rows currently being editted
            gvCourses.EditIndex = -1;

            ShowProducts();

            lblDisplay.Text = "";
        }

        public void ShowProducts()
        {
            String strSQL = "SELECT * FROM Course";
            gvCourses.DataSource = objDB.GetDataSet(strSQL);
            gvCourses.DataBind();
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }

}