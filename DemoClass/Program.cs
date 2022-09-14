using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (Date)
            // create object of Date class
            /* Date date = new Date();
             date.AssignValue();  // call to the method
             //string data = date.DisplayValue();
             //Console.WriteLine(data);
             // OR
             Console.WriteLine(date.DisplayValue()); */

            //    (student)
            /* Student s1 = new Student();
             s1.AssignValue();
             Console.WriteLine(s1.DisplayValue()); 
            */

            //    (Employee)
            Employee E1 = new Employee();
            E1.AssignValue();
            Console.WriteLine(E1.DisplayValue());
        }
    }
}
