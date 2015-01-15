using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;

namespace CourseRegistrationLibrary
{
    public class StudentFunctions
    {
        public string NewStudentRegestration(string firstName,string lastName, double balance, string street, string city, string state, string zip, string phone)
        {//Creates new student

            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO Students (FirstName,LastName,Balance,Street,City,State,Zip,Phone) VALUES ('" + firstName + "','" + lastName +"','" + balance + "','" + street + "','" + city + "','" + state + "','" + zip + "','" + phone + "') SELECT @@IDENTITY AS 'Identity'; ";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();
           

            objDB.CloseConnection();
            return ID;
        }
        //class was going to contain more but the editing of student information was not needed
    }
}
