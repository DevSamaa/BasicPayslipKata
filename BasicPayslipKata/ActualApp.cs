using System;

namespace BasicPayslipKata
{

    class ActualApp
    {
        public static float grossIncomeCalculator(int incomingUserAnnualSalary)
        {
            //Gross income = annual salary / 12 months
            float grossIncome = incomingUserAnnualSalary / 12;
            return grossIncome;
        }

        public static float incomeTaxCalculator(int incomingUserAnnualSalary)
        {
            int taxFreeAmount = 18200;

            if (incomingUserAnnualSalary <= 18200)
            {
                return 0;
            }
            else if (incomingUserAnnualSalary > 18200 && incomingUserAnnualSalary < 37001)
            {
                //return 19;
                int toBeTaxedAmount = incomingUserAnnualSalary - taxFreeAmount;
                float taxBracketOneAmount = Convert.ToSingle(toBeTaxedAmount * 0.19);
                return taxBracketOneAmount;

            }
            else
            {
                //this is just to test
                return 111;
            }
        }

        public static void payslipGenerator()
        {


            Console.WriteLine("Welcome to the payslip generator!");

            Console.WriteLine("Please input your first name:");
            string UserFirstName = Console.ReadLine();

            Console.WriteLine("Please input your last name:");
            string UserLastName = Console.ReadLine();


            Console.WriteLine("Please enter your annual salary:");
            int UserAnnualSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your super rate:");
            int UserSuperRate = int.Parse(Console.ReadLine());


            Console.WriteLine("Your payslip has been generated:");
            Console.WriteLine($"Name: {UserFirstName} {UserLastName}");
            Console.WriteLine($"Your Annual Salary is: {UserAnnualSalary} dollars");
            Console.WriteLine($"Your Super Rate is:{UserSuperRate}");

            Console.WriteLine($"Your Gross Income is:{grossIncomeCalculator(UserAnnualSalary)} per month.");

            Console.WriteLine($"Your Income Tax is:{incomeTaxCalculator(UserAnnualSalary)/12} per month.");
        }



    }
   
}
