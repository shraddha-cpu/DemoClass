using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{                       //Create a class
                        // Declare data members
                        //Assign values using method
                        //Display values using method

    public class Date
        {
            int day, year;
            string month;
                            // create a method to assign values to the data member
            public void AssignValue()
            {
                day = 13;
                month = "Sept";
                year = 2022;
            }
                            // method to display values
            public string DisplayValue()
            {
                return $"Date is :{day} / {month} / {year}";
            }

        }
    }


