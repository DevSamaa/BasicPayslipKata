using System;

namespace BasicPayslipKata
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ActualApp.payslipGenerator();

            var EmployeeInstance = new Employee();

            Console.WriteLine("Welcome to the payslip generator!");


            string userFirstName = EmployeeInstance.UserNameFetcher("first");
            string userFirstNameCapitilized = EmployeeInstance.CapitilizedName(userFirstName);

            string userLastName = EmployeeInstance.UserNameFetcher("last");
            string userLastNameCapitilized = EmployeeInstance.CapitilizedName(userLastName);

            string fullName = EmployeeInstance.FullNameGenerator(userFirstNameCapitilized, userLastNameCapitilized);

            Console.WriteLine(fullName);
        }
    }
}


