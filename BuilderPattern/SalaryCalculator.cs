using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculator
    {

        // this object is a complex object 
        // the complex object : the object that its constructor has many parameters (Complex Constructor), this parameters are optional, and other are required
        // the builder pattern is created to solve this problem, and to facilitate the creation of the object

        // the builder pattern is a creational pattern that is used to create a complex object with many parameters in its constructor


        // to implement the builder pattern, we need to create a builder class that has the same properties as the complex object,
        // and then we create a method in the builder class that returns the complex object .


        public SalaryCalculator(int taxPercentage=0, decimal bonusPercentage=0, decimal educationPackage=0
                        , decimal transportation=0, bool sendPaySlipToEmployee=true, bool postResultsToGL=true)
        {

            this.TaxPercentage = taxPercentage;
            this.BonusPercentage = bonusPercentage;
            this.EducationPackage = educationPackage;
            this.Transportation = transportation;
            this.SendPaySlipToEmployee = sendPaySlipToEmployee;
            this.PostResultsToGL = postResultsToGL;


        }



        // immutable properties
        public int TaxPercentage { get;}
        public decimal BonusPercentage { get; }
        public decimal EducationPackage { get; }
        public decimal Transportation { get; }
        public bool SendPaySlipToEmployee { get; }
        public bool PostResultsToGL { get; }



        public decimal Calculate(Employee employee)
        {
            var bonus = employee.BasicSalary * this.BonusPercentage/100;
            var taxes = employee.BasicSalary * this.TaxPercentage / 100;
            var salary = employee.BasicSalary + this.EducationPackage + this.Transportation + bonus - taxes;

            Console.ForegroundColor = ConsoleColor.Green;
            if(this.SendPaySlipToEmployee)
            {
                Console.WriteLine($"Sending Payslip to Employee{employee.Email}");
            }
            if (this.PostResultsToGL)
            {
                Console.WriteLine($"Salary Voucher With Total Salary ({salary})EGP has been sent to GL");
            }
            Console.ForegroundColor = ConsoleColor.White;



            return salary;
        }
    }
}
