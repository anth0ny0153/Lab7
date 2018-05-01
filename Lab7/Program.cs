using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateName();
            ValidateEmail();
            ValidatePhoneNumber();
            ValidateDate();

        }
        public static bool ValidateName()
        {   
            Console.Write("Please enter a valid name: ");
            string name = Console.ReadLine();
            if (!Regex.IsMatch(name, @"^[A-Z][a-z]{0,29}$"))
            {
                Console.WriteLine("Invalid name");
                ValidateName();
                return false;
            }
            else
            {
                Console.WriteLine("Valid name");
                return true;
            }
        }
        public static bool ValidateEmail()
        {
            Console.Write("Please enter a valid email: ");
            string email = Console.ReadLine();
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]{5,25}@[a-zA-Z0-9-]{5,10}\.[a-zA-Z0-9-.]{2,3}$"))
            {
                Console.WriteLine("Invalid email");
                ValidateEmail();
                return false;
            }
            else
            {
                Console.WriteLine("Valid email");
                return true;
            }
        }
        public static bool ValidatePhoneNumber()
        {
            Console.Write("Please enter a valid phone number(###.###.####): ");
            string phoneNumber = Console.ReadLine();
            if (!Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Invalid phone number");
                ValidatePhoneNumber();
                return false;
            }
            else
            {
                Console.WriteLine("Valid number");
                return true;
            }
        }
        public static bool ValidateDate()
        {
            Console.Write("Please enter a valid date(03/20/2000: ");
            string date = Console.ReadLine();
            if (!Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}$"))
            {
                Console.WriteLine("Invalid date");
                ValidateDate();
                return false;
            }
            else
            {
                Console.WriteLine("Valid date");
                return true;
            }
        }
    }
}
