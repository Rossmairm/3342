using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
namespace CourseRegistrationLibrary
{
    public class CouseRegistration
    {


        public DataSet SearchByDepDay(string Department, string DayCode)
        {
            //searches by user criteria ie: deparymeny and Day code
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Course WHERE DepartmentID LIKE '" + Department + "%' AND DayCode LIKE '" + DayCode + "%';";
            DataSet getDB = objDB.GetDataSet(strSQL);


            objDB.CloseConnection();

            return getDB;



        }

        public int CheckStudent(int StudentID)
        {//checks to make sure student exists
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Students WHERE StudentID =" + StudentID + " ;";
            int Checker;
            objDB.GetDataSet(strSQL, out Checker);
            return Checker;


        }

        public DataSet Roster(string StudentID)
        {//organizes roster info and returns dataset

        DBConnect objDB = new DBConnect();
        string strSQL = "SELECT Students.FirstName, Students.LastName ,Course.CRN, Course.CourseTitle, Course.DepartmentID, Course.Section, Course.Professor, Course.DayCode, Course.TimeCode, Course.CreditHours FROM Students LEFT JOIN CourseRegistration ON CourseRegistration.StudentID = Students.StudentID left join Course ON CourseRegistration.CRN = Course.CRN WHERE Students.StudentID='" + StudentID + "' AND CourseTitle IS NOT NULL";
        DataSet getDB = objDB.GetDataSet(strSQL);
        return getDB;

        
        }

       public int registration(string CRN, string StudentID)
        {
            //connects a student to a class

            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT NumberofSeatsAvailable FROM Course WHERE CRN = " + CRN + ";";//checks the number o0f available seats
            DataSet Seats = objDB.GetDataSet(strSQL);
            int seats = int.Parse(Seats.Tables[0].Rows[0].ItemArray[0].ToString());
            if (seats > 0)
            {
                strSQL = "UPDATE Course SET NumberofSeatsAvailable = NumberofSeatsAvailable - 1 WHERE CRN =" + CRN + ";";//decraments the available seats
                objDB.GetDataSet(strSQL);
                strSQL = "INSERT INTO CourseRegistration (CRN,StudentID) VALUES('" + CRN + "','" + StudentID + "') SELECT @@IDENTITY AS 'Identity';";//registars a student 
                DataSet RegNumber = objDB.GetDataSet(strSQL);
                objDB.CloseConnection();
                int regNum = int.Parse(RegNumber.Tables[0].Rows[0].ItemArray[0].ToString());
                return regNum;

            }

            objDB.CloseConnection();
            return -1;

        }
    }
}
