using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;



namespace PizzaLibrary
{
   public class PizzaFunctions
    {
   
       public void updateTotals(string pizzaType, int quantityOrdered, double amount )
       {                

        DBConnect objDB = new DBConnect();
        string strSQL = "UPDATE Pizzas SET TotalQuantityOrdered = TotalQuantityOrdered + "+ quantityOrdered+" WHERE PizzaType='"+pizzaType+
            "'";
            objDB.DoUpdate(strSQL);
          
           strSQL = "UPDATE Pizzas SET TotalSales = TotalSales + " + amount + " WHERE PizzaType='" + pizzaType + "'";
           objDB.DoUpdate(strSQL);
           objDB.CloseConnection();

       
       }
        public double SizeFinder(string size) //converts  size to a multiplier
        {
            if (size == "Large")
            {
                return 2;

            }
            else if (size == "Medium")
            {
                return 1.5;
            }
            else
            return 1;
        }

       public double PriceFinder(string pizzaType) //finds the price for the pizza type
       {
           double basePrice;

           String typePrice  = "SELECT BasePrice FROM Pizzas WHERE PizzaType='" + pizzaType + "'";

           DBConnect getPrice = new DBConnect();
           DataSet getDB = getPrice.GetDataSet(typePrice);
           getPrice.CloseConnection();

           basePrice = double.Parse(getDB.Tables[0].Rows[0][0].ToString());
           return basePrice;
          
           
       }
       public double returnSales(string pizzaType)
       {
           double sales;

           DBConnect objDB = new DBConnect();

           string strSQL = "SELECT TotalSales FROM Pizzas WHERE PizzaType='" + pizzaType + "'"; 
            DataSet getDB = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            sales = double.Parse(getDB.Tables[0].Rows[0].ItemArray[0].ToString());
           return sales;
       }


    }

}
    
