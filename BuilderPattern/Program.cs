

using BuilderPattern;

var builder = new SalaryCalculatorBuilder();

while (true)
{
    Console.WriteLine("Select An Option:");
    Console.WriteLine("1- Add 20% bonus");
    Console.WriteLine("2- Add 10% tax");
    Console.WriteLine("3- Add 2000 Education Package");
    Console.WriteLine("4- Add 1000 Transportation");
    Console.WriteLine("5- Send Payslip to Employee");
    Console.WriteLine("6- Post Voucher to GL");
    Console.WriteLine("0- Build");

    var option = int.Parse( Console.ReadLine());

    if (option ==1)
        builder.WithBonusPercentage(20);
    else if (option == 2)
        builder.WithTaxPercentage(10);
    else if (option == 3)
        builder.WithEducationPackage(2000);
    else if (option == 4)
        builder.WithTransportation(1000);
    else if (option == 5)
        builder.WithSendPaySlipToEmployee(true);
    else if (option == 6)
        builder.WithPostVouchersToGL(true);
    else if (option == 0)
    {
        var calculator = builder.Build();
        var employee = new Employee ("Mahmoud@email.com","Mahmoud", 10000);
        var salary = calculator.Calculate(employee);
        Console.ReadKey();

        // to make the user enter new values, and make the system perform new calculation 
        builder = new SalaryCalculatorBuilder();

    }
}