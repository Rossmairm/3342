using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationLibrary
{
    public class Student
    {
      //class was not needed beacuase there was no extra information manipulation 

        public Student() //initializes the pizza object
        {
           StudentID = "";
            Name = "";
           TuitionBalance = 0;
           

        }

        public string StudentID
        {

            set;
            get;

        }

        public string Name
        {
            set;
            get;

        }


        public double TuitionBalance
        {
            set;
            get;
            
        }


    }
}
