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
            Console.Write("\nEnter Last Name: ");
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
        public void Email()
        {
            Console.Write("\nEnter Email in form of (abc.xyz@bl.co.in): ");
            string email = Console.ReadLine();
            var regex = new Regex(@"^(abc)([.])([a-zA-Z0-9]+)[@]([b][l])[.]([c][o])[.]([a-z]{2})*$");
            bool match = regex.IsMatch(email);
            if (match == true)
            {
                Console.WriteLine("{0} is valid", email);
            }
            else
                Console.WriteLine("{0} is invalid. Enter email in given form ", email);
        }
        public void MobileNumber()
        {
            Console.Write("\nEnter Mobile Number in form of +(country code) (10 digit number): ");
            string mobileNumber = Console.ReadLine();
            var regex = new Regex(@"^[+][1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}");
            bool match = regex.IsMatch(mobileNumber);
            if (match == true)
            {
                Console.WriteLine("{0} is valid", mobileNumber);
            }
            else
            {
                Console.WriteLine("{0} is invalid", mobileNumber);
            }
        }
        public void Password()
        {
            Console.Write("\nEnter a Password (atleast 1 capital ltter and 1 number ) : ");
            string password = Console.ReadLine();
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
            bool match = regex.IsMatch(password);
            if (match == true)
            {
                Console.WriteLine("{0} is valid", password);
            }
            else
            {
                Console.WriteLine("{0} is invalid.", password);
            }
        }
    }
}
