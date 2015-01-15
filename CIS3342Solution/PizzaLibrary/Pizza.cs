using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PizzaLibrary
{


    class Pizza
    {
        
      
          public Pizza()
      {
          PizzaType="";
          Size = 1;
          Quantity=0;
          Price = 0 ;
          TotalCost=0;
   
    }
        


      private string PizzaType
    {
          set;
          get;
    }
      private double Size
    {
          set;
          get;
    }
    private int Quantity
    {   
        set;
        get;
    }
    private double Price
    {
        set;
        get;

    }
    private double TotalCost
    {
        set;
        get;
    }
    
      }
  

    }


