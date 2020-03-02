using System;

namespace BasicPayslipKata
{

    class ActualApp
    {
       
        public static decimal grossIncomeCalculator(int incomingUserAnnualSalary)
        {
            //Gross income = annual salary / 12 months
            decimal grossIncomeAmount = incomingUserAnnualSalary / 12;
            return grossIncomeAmount;
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
            else if (incomingUserAnnualSalary > 37000 && incomingUserAnnualSalary < 87001)
            {
                int toBeTaxedAmount = incomingUserAnnualSalary - 37000;
                float taxBracketTwoAmount = Convert.ToSingle(toBeTaxedAmount * 0.325);
                float taxBracketTwoPlusPrevious = taxBracketTwoAmount + 3572;
                return taxBracketTwoPlusPrevious;
            }
            else if (incomingUserAnnualSalary > 87000 && incomingUserAnnualSalary < 180001)
            {
                int toBeTaxedAmount = incomingUserAnnualSalary - 87000;
                float taxBracketThreeAmount = Convert.ToSingle(toBeTaxedAmount * 0.37);
                float taxBracketThreePlusPrevious = taxBracketThreeAmount + 19822;
                return taxBracketThreePlusPrevious;
            }

            else
            {
                int toBeTaxedAmount = incomingUserAnnualSalary - 180000;
                float taxBracketFourAmount = Convert.ToSingle(toBeTaxedAmount * 0.45);
                float taxBracketFourPlusPrevious = taxBracketFourAmount + 54232;
                return taxBracketFourPlusPrevious;
            }

        }

        public static float netIncome(float incomingGrossIncome, float incomingIncomeTax)
        {
            float netIncome = incomingGrossIncome - incomingIncomeTax;
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
            int UserAnnualSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your super rate:");
            int UserSuperRate = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your payment start date:");
            string UserStartDate = Console.ReadLine();

            Console.WriteLine("Please enter your payment end date:");
            string UserEndDate = Console.ReadLine();


            Console.WriteLine("Your payslip has been generated:");
            Console.WriteLine($"Name: {UserFirstName} {UserLastName}");
            Console.WriteLine($"Pay Period: {UserStartDate} - {UserEndDate}");
           

            float grossIncome = grossIncomeCalculator(UserAnnualSalary);
            double grossIncomeRounded = Math.Round(grossIncome, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Gross Income rounded is: {grossIncomeRounded} per month.");

            float incomeTax = incomeTaxCalculator(UserAnnualSalary)/12;
            double incomeTaxRounded = Math.Round(incomeTax, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Income Tax rounded is {incomeTaxRounded} per month.");

            double netIncomeRounded = Math.Round(netIncome(grossIncome, incomeTax), 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Net Income rounded is {netIncomeRounded} per month.");

            float superAmount = (grossIncome/100) * UserSuperRate;
            double superAmountRounded = Math.Round(superAmount, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Your Super is {superAmountRounded} per month.");

            Console.WriteLine("Thank you for using MYOB");
        }



    }
   
}
