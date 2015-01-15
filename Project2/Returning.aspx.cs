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

namespace Project2
{
    public partial class Returning : System.Web.UI.Page
    {
        CouseRegistration function = new CouseRegistration();
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
            DataSet Searched = function.SearchByDepDay(txtDepartment.Text, txtDayCode.Text);

            gvCourses.DataSource = Searched;
            gvCourses.DataBind();

        }


        public void ShowProducts()
        {
            String strSQL = "SELECT * FROM Course";
            gvCourses.DataSource = objDB.GetDataSet(strSQL);
            gvCourses.DataBind();

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            CheckBox checker;
            lblDisplay.Text = "";
            int Num;

            if (txtStudentID.Text == "")//validation
            {
                lblDisplay.Text = "Enter a Student";
            }
            else if (!int.TryParse(txtStudentID.Text.ToString(), out Num))//validation
            {
                lblDisplay.Text = "Invaild Student Number";

            }
            else if (function.CheckStudent(int.Parse(txtStudentID.Text)) == 0)//validation
            {
                lblDisplay.Text = "Invaild Student Number";
            }
            else
            {
                for (int i = 0; i < gvCourses.Rows.Count; i++)//checks for selected boxes
                {
                    checker = (CheckBox)gvCourses.Rows[i].FindControl("chkSelect");
                    if (checker.Checked)
                    {
                        string CRN = gvCourses.Rows[i].Cells[1].Text;

                        int CheckUpdate = function.registration(CRN, txtStudentID.Text);
                        if (CheckUpdate == -1)
                        {
                            lblDisplay.Text = "Course Full";
                        }
                        else
                            lblDisplay.Text = "Registartion Number :" + CheckUpdate;
                    }
                }
            }
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}


