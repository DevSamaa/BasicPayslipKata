using System;

namespace BasicPayslipKata
{

    class ActualApp
    {
       
        public static decimal grossIncomeCalculator(decimal incomingUserAnnualSalary)
        {
            //Gross income = annual salary / 12 months
            decimal grossIncomeAmount = incomingUserAnnualSalary / 12;
            return grossIncomeAmount;
        }

        public static decimal incomeTaxCalculator(decimal incomingUserAnnualSalary)
        {
            decimal taxFreeAmount = 18200;

            if (incomingUserAnnualSalary <= 18200)
            {
                return 0;
            }
            else if (incomingUserAnnualSalary > 18200 && incomingUserAnnualSalary < 37001)
            {
                decimal toBeTaxedAmount = incomingUserAnnualSalary - taxFreeAmount;
             
                decimal taxRate1 = Convert.ToDecimal(0.19);
                decimal taxBracketOneAmount = toBeTaxedAmount * taxRate1;
                return taxBracketOneAmount;

            }
            else if (incomingUserAnnualSalary > 37000 && incomingUserAnnualSalary < 87001)
            {
                decimal toBeTaxedAmount = incomingUserAnnualSalary - 37000;
                decimal taxRate2 = Convert.ToDecimal(0.325);
                decimal taxBracketTwoPlusPrevious = (toBeTaxedAmount *taxRate2) + 3572;
                return taxBracketTwoPlusPrevious;
            }
            else if (incomingUserAnnualSalary > 87000 && incomingUserAnnualSalary < 180001)
            {
                decimal toBeTaxedAmount = incomingUserAnnualSalary - 87000;
                decimal taxRate3 = Convert.ToDecimal(0.37);
                decimal taxBracketThreePlusPrevious = (toBeTaxedAmount *taxRate3) + 19822;
                return taxBracketThreePlusPrevious;
            }

            else
            {
                decimal toBeTaxedAmount = incomingUserAnnualSalary - 180000;
                decimal taxRate4 = Convert.ToDecimal(0.45);
                decimal taxBracketFourPlusPrevious = (toBeTaxedAmount * taxRate4) + 54232;
                return taxBracketFourPlusPrevious;
            }

        }

        public static decimal netIncome(decimal incomingGrossIncome, decimal incomingIncomeTax)
        {
            decimal netIncome = incomingGrossIncome - incomingIncomeTax;
            return netIncome;
        }

        public static void payslipGenerator()
        {


            Console.WriteLine("Welcome to the payslip generator!");

            Console.WriteLine("Please input your first name:");
            string UserFirstName = Console.ReadLine();

            Console.WriteLine("Please input your last name:");
            string UserLastName = Console.ReadLine();


            Console.WriteLine("Please enter your annual salary:");
            decimal UserAnnualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your super rate:");
            decimal UserSuperRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your payment start date:");
            string UserStartDate = Console.ReadLine();

            Console.WriteLine("Please enter your payment end date:");
            string UserEndDate = Console.ReadLine();


            Console.WriteLine("Your payslip has been generated:");
            Console.WriteLine($"Name: {UserFirstName} {UserLastName}");
            Console.WriteLine($"Pay Period: {UserStartDate} - {UserEndDate}");
           

            decimal grossIncome = grossIncomeCalculator(UserAnnualSalary);
            decimal grossIncomeRounded = Math.Round(grossIncome, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Gross Income rounded is: {grossIncomeRounded} per month.");

            decimal incomeTax = incomeTaxCalculator(UserAnnualSalary)/12;
            decimal incomeTaxRounded = Math.Round(incomeTax, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Income Tax rounded is {incomeTaxRounded} per month.");

            decimal netIncomeRounded = Math.Round(netIncome(grossIncome, incomeTax), 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Net Income rounded is {netIncomeRounded} per month.");

            decimal superAmount = (grossIncome/100) * UserSuperRate;
            decimal superAmountRounded = Math.Round(superAmount, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Super is {superAmountRounded} per month.");

            Console.WriteLine("Thank you for using MYOB");
        }



    }
   
}
