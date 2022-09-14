using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    public class Employee
    {
        int Emp_id, salary;
        string name, address, email;
        public void AssignValue()
        {
            Emp_id=11;
            name="mr.deshmukh";
            address="karvengar pune";
            email="omdeshmukh123@gmail.com";
            salary=50000;
        }
        public string DisplayValue()
        {
            return $"Employee  : id is {Emp_id}  / name is {name} / address is {address} / email is {email} / salary is {salary}";        }
        }
    }








