using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Utilities;
using WebServices;




namespace Project3WS
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet HomeSearch(string city, string state)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Homes WHERE City = '" + city + "' AND State = '" + state + "'";
            DataSet Searched = objDB.GetDataSet(strSQL);
            return Searched;



        }

        [WebMethod]
        public DataSet pullSet()
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Homes";
            DataSet Searched = objDB.GetDataSet(strSQL);
            return Searched;
        }
        [WebMethod]
        public DataSet MaxSearch(string city, string state, double max)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Homes WHERE City = '" + city + "' AND State = '" + state + "' AND ListingPrice <= '" + max + "'";
            DataSet Searched = objDB.GetDataSet(strSQL);
            return Searched;
        }
        
        [WebMethod]
        public DataSet SizeSearch(string city, string state, int size)
        {

            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Homes WHERE City = '" + city + "' AND State = '" + state + "' AND SquareFootage >= '" + size + "'";
            DataSet Searched = objDB.GetDataSet(strSQL);
            return Searched;
        }
        
        [WebMethod]
        public DataSet TypeSearch(string city, string state, string type)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "SELECT * FROM Homes WHERE City = '" + city + "' AND State = '" + state + "' AND Type = '" + type + "'";
            DataSet Searched = objDB.GetDataSet(strSQL);
            return Searched;
        }
        
        [WebMethod]
        public string Booking(int home, int client, int realtor)
        {

            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO HomeShowingRequests(RealtorID, HomeID, ClientID) VALUES ('" + realtor + "','" + home+ "','" + client + "') SELECT @@IDENTITY AS 'Identity' ";
            DataSet Booked = objDB.GetDataSet(strSQL);
            string ID = Booked.Tables[0].Rows[0][0].ToString();
            return ID;

            
        }
        
    
        [WebMethod]
        public string UpdateHomes(string address, string city,string state, int price, int SF, string availability, int bedrooms, double bathrooms,string Type)
        {
            //updates all feilds incase of any changes
            DBConnect objDB = new DBConnect();
            string strSQL = "UPDATE Homes SET Address = '" + address + "', City = '" + city + "', State = '" + state + "', ListingPrice = '" + price + "', SquareFootage = '" + SF + "', Availability = '" + availability + "', Bedrooms = '" +bedrooms + "', Bathrooms='" +bathrooms+"', Type ='" +Type+"' SELECT @@IDENTITY AS 'Identity';";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();


            objDB.CloseConnection();
            return ID; 

        }
        [WebMethod]
        public void DeleteEntry(string ID)
        {
            // deletes an entire row
            DBConnect objDB = new DBConnect();
            string strSQL = "DELETE FROM Homes WHERE HomeID ='" + ID + "';";
            DataSet getDB = objDB.GetDataSet(strSQL);

            objDB.CloseConnection();
                    }

        [WebMethod]
        public string addClient(Client client)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO Client (firstName,lastName) VALUES ('" + client.firstName +"','"+ client.lastName + "') SELECT @@IDENTITY AS 'Identity' ";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();


            objDB.CloseConnection();
            return ID;
        }

        [WebMethod]
        public string addHome(Home home)
        {
            DBConnect objDB = new DBConnect();
            string strSQL = "INSERT INTO Homes (Address, City, State, ListingPrice, SquareFootage, Availability, Bedrooms, Bathrooms, Type) VALUES ('" + home.address + "','" + home.city + "','" + home.state + "','" + home.price + "','" + home.SF + "','" + home.availability + "','" + home.bedrooms + "','" + home.bathrooms+"','" +home.Type+ "') SELECT @@IDENTITY AS 'Identity' ";
            DataSet getDB = objDB.GetDataSet(strSQL);
            string ID = getDB.Tables[0].Rows[0][0].ToString();


            objDB.CloseConnection();
            return ID;
        }
        [WebMethod]
        public DataSet getClientID()
        {
            DBConnect objDB = new DBConnect();
            string sql ="SELECT ClientID FROM Client";
            DataSet client = objDB.GetDataSet(sql);
            return client;

        }
        [WebMethod]
        public DataSet getRealtorID()
        {
            DBConnect objDB = new DBConnect();
            string sql = "SELECT RealtorID FROM Realtor";
            DataSet client = objDB.GetDataSet(sql);
            return client;

        }
        [WebMethod]
        public DataSet getReservations()
        {
            DBConnect objDB = new DBConnect();
            string sql = "SELECT HomeShowingRequests.RequestID, Client.firstName, Client.lastName, HomeShowingRequests.RealtorID, HomeShowingRequests.HomeID, Homes.Address FROM Client,Realtor,HomeShowingRequests,Homes  WHERE HomeShowingRequests.HomeID = Homes.HomeID AND HomeShowingRequests.RealtorID =Realtor.RealtorID AND HomeShowingRequests.ClientID = Client.ClientID ";
            DataSet client = objDB.GetDataSet(sql);
            return client;

        }
    
    }
}
