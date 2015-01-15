using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PizzaLibrary
{


    public class Pizza
    {


        public Pizza() //initializes the pizza object
        {
            PizzaType = "";
            Size = 1;
            Quantity = 0;
            Price = 0;
            TotalCost = 0;

        }



        public string PizzaType
        {
            set;
            get;
        }
        public double Size
        {
            set;
            get;
        }
        public int Quantity
        {
            set;
            get;
        }
        public double Price
        {
            set;
            get;

        }
        public double TotalCost
        {
            set;
            get;
        }

    }
}

