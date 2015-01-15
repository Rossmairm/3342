using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Text.RegularExpressions;


namespace Project3
{
    public partial class EditHomes : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
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


            lblDisplay.Text = "HELLO";

        }


        protected void gvCourses_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int bedrooms;
            int SF;
            int Price;
            double bathrooms;

            string HomeID = gvHomes.Rows[rowIndex].Cells[0].Text;

            TextBox Address;//creates text box
            Address = (TextBox)gvHomes.Rows[rowIndex].Cells[1].Controls[0];//adds the info to the text box
            string address = Address.Text;//appends to a string

            TextBox City;
            City = (TextBox)gvHomes.Rows[rowIndex].Cells[2].Controls[0];
            string city = City.Text;

            TextBox State;
            State = (TextBox)gvHomes.Rows[rowIndex].Cells[3].Controls[0];
            string state = State.Text;


            TextBox ListingPrice;
            ListingPrice = (TextBox)gvHomes.Rows[rowIndex].Cells[4].Controls[0];
            string listingPrice = ListingPrice.Text;

            TextBox SquareFootage;
            SquareFootage = (TextBox)gvHomes.Rows[rowIndex].Cells[5].Controls[0];
            string squareFootage = SquareFootage.Text;

            TextBox Availability;
            Availability = (TextBox)gvHomes.Rows[rowIndex].Cells[6].Controls[0];
            string availability = Availability.Text;

            TextBox Bedrooms;
            Bedrooms = (TextBox)gvHomes.Rows[rowIndex].Cells[7].Controls[0];
            string bedroom = Bedrooms.Text;

            TextBox Bathrooms;
            Bathrooms = (TextBox)gvHomes.Rows[rowIndex].Cells[8].Controls[0];
            string bathroom = Bathrooms.Text;

            TextBox Type;
            Type = (TextBox)gvHomes.Rows[rowIndex].Cells[9].Controls[0];
            string type = Type.Text;


            //makes sure they are not blank

            if (address == "" || city == "" || state == "" || listingPrice == "" || squareFootage == "" || bedroom == "" || bathroom == "" || type == "")
            {
                lblDisplay.Text = "Please fill out all fields.";
            }
            else
            {
                if (!(availability == "sold" || availability == "for sale" || availability == "foreclosure"))//input validation
                {

                    lblDisplay.Text = "Avaibaility must be sold, for sale, or foreclosure";
                }
                else
                {
                    if (!(type == "Single" || type == "Row Home" || type == "Apartment"))//input validation
                    {

                        lblDisplay.Text = "Avaibaility must be Single, Row Home, or Apartment";
                    }
                    else
                    {

                        if (!(int.TryParse(listingPrice, out Price)))//input validation
                        {
                            lblDisplay.Text = "Invalid price must be an int";
                        }
                        else
                        {

                            if (!(int.TryParse(bedroom, out bedrooms)))//input validation
                            {
                                lblDisplay.Text = "Invalid bedrooms must be an int";
                            }
                            else
                            {
                                if (!(double.TryParse(bathroom, out bathrooms)))//input validation
                                {
                                    lblDisplay.Text = "Invaild Bathrooms must be a number";
                                }
                                else
                                {
                                    if (!(int.TryParse(squareFootage, out SF)))//input validation
                                    {
                                        lblDisplay.Text = "Invalid Square footage must be an int";
                                    }
                                    else
                                    {

                                        lblDisplay.Text = pxy.UpdateHomes(address, city, state, Price, SF, availability, bedrooms, bathrooms, type);

                                        // Set the GridView back to the original state.
                                        // No rows currently being edited.
                                        gvHomes.EditIndex = -1;
                                        ShowHomes();

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void gvHomes_RowEditing(Object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            // Set the row to edit-mode in the GridView
            gvHomes.EditIndex = e.NewEditIndex;
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Homes";
            DataSet myDS = objDB.GetDataSet(strSQL);



            gvHomes.DataSource = myDS;
            gvHomes.DataBind();
            lblDisplay.Text = "";
        }

        protected void gvHomes_RowDeleteing(Object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string ID = gvHomes.Rows[rowIndex].Cells[0].Text;
            pxy.DeleteEntry(ID);
          
            ShowHomes();

        }
        protected void gvHomes_RowCancelingEdit(Object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state
            // No rows currently being editted
            gvHomes.EditIndex = -1;

            ShowHomes();

            lblDisplay.Text = "";
        }
        public void ShowHomes()
        {
            String strSQL = "SELECT * FROM Homes";
            gvHomes.DataSource = objDB.GetDataSet(strSQL);
            gvHomes.DataBind();
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
            
        }

    }
}