using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Employee
    {

        public Employee(string email, string name, decimal basicSalary)
        {
            Email = email;
            Name = name;
            BasicSalary = basicSalary;
        }

        public string Email { get;}
        public string Name { get;}

        public decimal BasicSalary { get; }
    }
}
