using System;

namespace BasicPayslipKata
{

    class ActualApp
    {
       
        //public static decimal grossIncomeCalculator(decimal incomingUserAnnualSalary)
        //{
        //    //Gross income = annual salary / 12 months
        //    decimal grossIncomeAmount = incomingUserAnnualSalary / 12;
        //    return grossIncomeAmount;
        //}

        //public static decimal incomeTaxCalculator(decimal incomingUserAnnualSalary)
        //{
        //    decimal taxFreeAmount = 18200;

        //    if (incomingUserAnnualSalary <= 18200)
        //    {
        //        return 0;
        //    }
        //    else if (incomingUserAnnualSalary > 18200 && incomingUserAnnualSalary < 37001)
        //    {
        //        decimal toBeTaxedAmount = incomingUserAnnualSalary - taxFreeAmount;
        //        decimal taxRate1 = Convert.ToDecimal(0.19);
        //        decimal taxBracketOneAmount = toBeTaxedAmount * taxRate1;
        //        return taxBracketOneAmount;

        //    }
        //    else if (incomingUserAnnualSalary > 37000 && incomingUserAnnualSalary < 87001)
        //    {
        //        decimal toBeTaxedAmount = incomingUserAnnualSalary - 37000;
        //        decimal taxRate2 = Convert.ToDecimal(0.325);
        //        decimal taxBracketTwoPlusPrevious = (toBeTaxedAmount *taxRate2) + 3572;
        //        return taxBracketTwoPlusPrevious;
        //    }
        //    else if (incomingUserAnnualSalary > 87000 && incomingUserAnnualSalary < 180001)
        //    {
        //        decimal toBeTaxedAmount = incomingUserAnnualSalary - 87000;
        //        decimal taxRate3 = Convert.ToDecimal(0.37);
        //        decimal taxBracketThreePlusPrevious = (toBeTaxedAmount *taxRate3) + 19822;
        //        return taxBracketThreePlusPrevious;
        //    }

        //    else
        //    {
        //        decimal toBeTaxedAmount = incomingUserAnnualSalary - 180000;
        //        decimal taxRate4 = Convert.ToDecimal(0.45);
        //        decimal taxBracketFourPlusPrevious = (toBeTaxedAmount * taxRate4) + 54232;
        //        return taxBracketFourPlusPrevious;
        //    }

        //}

        //public static decimal netIncome(decimal incomingGrossIncome, decimal incomingIncomeTax)
        //{
        //    decimal netIncome = incomingGrossIncome - incomingIncomeTax;
        //    return netIncome;
        //}

        //public static string DateGenerator(string startOrEnd)
        //{
        //    string userDate = "";
        //    while (userDate == "")
        //    {
        //        Console.WriteLine($"Please enter your payment {startOrEnd} date:");
        //        userDate = Console.ReadLine();
        //    }
        //    return userDate;
        //}

        

        //public static decimal AnnualSalaryGenerator()
        //{
        //    bool checkIfNumber = false;
        //    decimal checkedUserAnnualSalary = 0;
        //    while (checkIfNumber == false)
        //    {
        //        Console.WriteLine("Please enter your annual salary:");
        //        string UserAnnualSalary = Console.ReadLine();
        //        checkIfNumber = decimal.TryParse(UserAnnualSalary, out checkedUserAnnualSalary);
        //        if (checkIfNumber == true && checkedUserAnnualSalary >= 0)
        //        {
        //            //keep going
        //            break;
        //        }
        //        else
        //        {
        //            checkIfNumber = false;
        //        }
        //    }
        //    return checkedUserAnnualSalary;

        //}

        //public static decimal UserSuperRateGenerator()
        //{
        //    decimal UserSuperRate;
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("Please enter your super rate:");
        //            UserSuperRate = Convert.ToDecimal(Console.ReadLine());
        //            if (UserSuperRate >= 0 && UserSuperRate <= 50)
        //            {
        //                break;
        //            }

        //        }
        //        catch (FormatException e)
        //        {
        //            Console.WriteLine("Something went wrong. You need to enter a number between 0 and 50!!!");
        //        }

        //    }
        //    return UserSuperRate;
        //}

        //public static void payslipGenerator()
        //{
        //    Console.WriteLine("Welcome to the payslip generator!");

        //    string UserFirstNameEdited = NameGenerator("first");

        //    string UserLastNameEdited = NameGenerator("last");

        //    decimal checkedUserAnnualSalary = AnnualSalaryGenerator();

        //    decimal UserSuperRate = UserSuperRateGenerator();

        //    string UserStartDate = DateGenerator("start");

        //    string UserEndDate = DateGenerator("end");


        //    Console.WriteLine("\n********************************");
        //    Console.WriteLine("Your payslip has been generated:");
        //    Console.WriteLine($"Name: {UserFirstNameEdited} {UserLastNameEdited}");
        //    Console.WriteLine($"Pay Period: {UserStartDate} - {UserEndDate}");


        //    decimal grossIncome = grossIncomeCalculator(checkedUserAnnualSalary);
        //    decimal grossIncomeRounded = Math.Round(grossIncome, 0, MidpointRounding.AwayFromZero);
        //    Console.WriteLine($"Your Gross Income rounded is: {grossIncomeRounded} per month.");

        //    decimal incomeTax = incomeTaxCalculator(checkedUserAnnualSalary) /12;
        //    decimal incomeTaxRounded = Math.Round(incomeTax, 0, MidpointRounding.AwayFromZero);
        //    Console.WriteLine($"Your Income Tax rounded is {incomeTaxRounded} per month.");

        //    decimal netIncomeRounded = Math.Round(netIncome(grossIncome, incomeTax), 0, MidpointRounding.AwayFromZero);
        //    Console.WriteLine($"Your Net Income rounded is {netIncomeRounded} per month.");

        //    decimal superAmount = (grossIncome/100) * UserSuperRate;
        //    decimal superAmountRounded = Math.Round(superAmount, 0, MidpointRounding.AwayFromZero);
        //    Console.WriteLine($"Your Super is {superAmountRounded} per month.");

        //    Console.WriteLine("Thank you for using MYOB");
        //}



    }
   
}
