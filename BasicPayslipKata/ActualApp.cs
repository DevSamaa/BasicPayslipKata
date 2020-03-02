using System;

namespace BasicPayslipKata
{

    class ActualApp
    {
        public static void payslipGenerator()
        {
            Console.WriteLine("Welcome to the payslip generator!");

            Console.WriteLine("Please input your first name:");
            string UserFirstName = Console.ReadLine();

            Console.WriteLine("Please input your last name:");
            string UserLastName = Console.ReadLine();


            Console.WriteLine("Please enter your annual salary:");
            int UserAnnualSalary = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {UserFirstName} {UserLastName}");
            Console.WriteLine($"Your Annual Salary is: {UserAnnualSalary} dollars");
        }


    }
   
}
