using System;
namespace BasicPayslipKata
{
    public class Employee
    {
        public string UserNameFetcher(string firstOrLastName)
        {
            while (true)
            {
               
                    Console.WriteLine($"Please input your {firstOrLastName} name:");

                    string userinput = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(userinput))
                    {
                        continue;
                    }
                    return userinput;

                    //These are two other ways of doing the above
                    //if (!String.IsNullOrWhiteSpace(userinput))
                    //{
                    //    return userinput;
                    //}

                    //if (String.IsNullOrWhiteSpace(userinput) == false)
                    //{
                    //    return userinput;
                    //}
            }
        }

        public string CapitilizedName(string incomingUserName)
        {
            //There is no need to store this inside a variable, because you're not doing anything else with it inside this function!
            return char.ToUpper(incomingUserName[0]) + incomingUserName.Substring(1);
        }


        public  string FullNameGenerator(string incomingFirstName, string incomingLastname)
        {
            return $"{incomingFirstName} {incomingLastname}";
            //return fullname;
        }
    }

}


