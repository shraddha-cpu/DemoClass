using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    public class Student
    {
        int id, age;
        string name, address;
        public void AssignValue()
        {
            id=1;
            name="shraddha";
            address="shivane,pune-23";
            age=22;
        }
        public string DisplayValue()
        {
            return $"Student  : id is {id} / name is {name} / address is {address} / age is {age}";
        }
    

    }
}
