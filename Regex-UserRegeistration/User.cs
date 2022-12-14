using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_UserRegeistration
{
    internal class User
    {
        public void FirstName()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            bool match = regex.IsMatch(firstName);
            if (match == true)
            {
                Console.WriteLine("{0} is valid", firstName);
            }
            else
                Console.WriteLine("{0} is invalid. Enter First Name starts with Capital latter and has minimum 3 characters", firstName);

        }
        public void LastName()
        {
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            bool match = regex.IsMatch(lastName);
            if (match == true)
            {
                Console.WriteLine("{0} is valid", lastName);
            }
            else
                Console.WriteLine("{0} is invalid. Enter First Name starts with Capital latter and has minimum 3 characters", lastName);

        }
    }
}
