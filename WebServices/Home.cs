using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices
{
    public class Home
    {
        public Home()
        {
            address = "";
            city = "";
            state = "";
            price = 0;
            SF = 0;
            availability = "";
            bedrooms = 0;
            bathrooms = 0;
            Type = "";
         }


        public string address
        {
            set;
            get;

        }
        public string city
        {
            set;
            get;

        }
        public string state
        {
            set;
            get;

        }
        public int price
        {
            set;
            get;


        }
        public int SF
        {
            set;
            get;

        }
        public string availability
        {
            set;
            get;

        }
        public int bedrooms
        {
            set;
            get;

        }
        public double bathrooms
        {
            set;
            get;

        }
        public string Type
        {
            set;
            get;

        }

    }
}
