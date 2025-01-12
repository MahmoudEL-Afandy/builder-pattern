using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SalaryCalculatorBuilder
    {
        // to implement the builder pattern, we need to create a builder class that has the same properties as the complex object,
        // and then we create a method in the builder class that returns the complex object .

        // this all variables the SalaryCalculator Constructor get it to create new object from this class (SalaryCalculator)
        private int _taxPercentage = 0;
        private decimal _bonusPercentage = 0;
        private decimal _educationPackage = 0;
        private decimal _transportation = 0;
        private bool _sendPaySlipToEmployee = true;
        private bool _postResultsToGL = true;

        // we will set each variable with the value that we want to set it with it by specific method for this variable ( this way Called Fluent API)
        


        public SalaryCalculatorBuilder WithTaxPercentage(int taxPercentage)
        {
            LogMessage ($"{taxPercentage} Tax Percentage is set");
            _taxPercentage = taxPercentage;
            return this;
        }

        public SalaryCalculatorBuilder WithBonusPercentage(decimal bonusPercentage)
        {
            LogMessage($"{bonusPercentage} Bonus Percentage is Set ");
            _bonusPercentage = bonusPercentage;
            return this;
        }
        public SalaryCalculatorBuilder WithEducationPackage(decimal educationPackage)
        {
            LogMessage($"{educationPackage} Education Package is Set ");
            _educationPackage = educationPackage;
            return this;
        }
        public SalaryCalculatorBuilder WithTransportation(decimal transportation)
        {
            LogMessage($"{transportation} Transportation is Set ");
            _transportation = transportation;
            return this;
        }
        public SalaryCalculatorBuilder WithSendPaySlipToEmployee(bool sendPaySlipToEmployee)
        {
            _sendPaySlipToEmployee = sendPaySlipToEmployee;
            return this;
        }
        public SalaryCalculatorBuilder WithPostVouchersToGL(bool postResultsToGL)
        {
            _postResultsToGL = postResultsToGL;
            return this;
        }
        private void LogMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public SalaryCalculator Build()
        {
           
            return new SalaryCalculator(_taxPercentage, _bonusPercentage, _educationPackage, _transportation, _sendPaySlipToEmployee, _postResultsToGL);
        }
    }
}
