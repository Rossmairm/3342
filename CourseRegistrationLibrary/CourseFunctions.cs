using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;

namespace CourseRegistrationLibrary
{
   public class CourseFunctions
    {
        public string Newcourse(string Title,  string DepartmentID, string Section, string Professor, string DayCode, string TimeCode, double CreditHours, int Seats, int MaxSeats)
        {//adds new course requiring all feilds

            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO Course (CourseTitle,DepartmentID,Section,Professor,Daycode,TimeCode,CreditHours, NumberofSeatsAvailable, Maximumseats) VALUES ('" + Title + "','" + DepartmentID + "','" + Section + "','" + Professor + "','" + DayCode + "','" + TimeCode + "','" + CreditHours + "','" + Seats + "','" + MaxSeats + "') SELECT @@IDENTITY AS 'Identity' ";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();


            objDB.CloseConnection();
            return ID;
        }

        public DataSet CourseSearch(string SearchRow, string Keyword)
        {
            //returns searched information
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Course WHERE " + SearchRow + " LIKE '" + Keyword + "%';";
            DataSet getDB = objDB.GetDataSet(strSQL);
      
     
          objDB.CloseConnection();

            return getDB;


        }

        public string UpdateCourse(string CRN, string Title, string DepartmentID, string Section, string Professor, string DayCode, string TimeCode, double CreditHours, int Seats, int MaxSeats)
        { 
            //updates all feilds incase of any changes
             DBConnect objDB = new DBConnect();
             string strSQL = "UPDATE Course SET CourseTitle = '" + Title + "', DepartmentId = '" + DepartmentID + "', Section = '" + Section + "', Professor = '" + Professor + "', DayCode = '" + DayCode + "', TimeCode = '" + TimeCode + "', CreditHours = " + CreditHours + ", NumberOfSeatsAvailable="+ Seats+", MaximumSeats = " + MaxSeats + " WHERE CRN = " + CRN + " SELECT @@IDENTITY AS 'Identity';";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();


            objDB.CloseConnection();
            return ID; 
        }
        public void DeleteEntry(string CRN)
        {
            // deletes an entire row
            DBConnect objDB = new DBConnect();
            string strSQL = "DELETE FROM Course WHERE CRN ='"+ CRN + "';";
            DataSet getDB = objDB.GetDataSet(strSQL);
           
            objDB.CloseConnection();

                   
        
        }
   
   }
}
