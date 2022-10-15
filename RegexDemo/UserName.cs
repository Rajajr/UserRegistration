using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace RegexDemo
{
    class UserName
    {
        public static void UsersFirstName()
        {

            string[] arr = { "Raja", "raja", "ra24", "RAja678" };
            string pattern = "^[A-Z][a-z][0-9]{3,}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Fist Name matches", input);
                else
                    Console.WriteLine("{0} User First Name Doesn't matches", input);
                Console.WriteLine("-------------------------------------------------");
            }

        }
        public static void UserLastName()
        {
            string[] arr = { "Ravi", "ravi", "ra24", "RAvi678" };
            string pattern = "^[A-Z][a-z][0-9]{3,}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User last Name matches", input);
                else
                    Console.WriteLine("{0} User last Name Doesn't matches", input);
                Console.WriteLine("--------------------------------------------------");
            }
        }
        public static void Email()
        {
            string[] arr = { "rajjr011@gmail.com", "rajJR011@GMAIL", "raJAjr234@gmail.com" };
            string pattern = @"^[a-z0-9_\-\.]+[@][a-z]+[\.][a-z]{3,}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Email matches", input);
                else
                    Console.WriteLine("{0} User Email Doesn't matches", input);
                Console.WriteLine("--------------------------------------------------");
            }
        }
        public static void PhoneNumber()
        {
            string[] arr = { "916379386500", "458765654455", "7819815787" };
            string pattern = @"^[91][0-9]{10,}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Mobile Number matches", input);
                else
                    Console.WriteLine("{0} User Mobile Number Doesn't matches", input);
                Console.WriteLine("--------------------------------------------------");
            }
            
        }
        public static void Password()
        {
            string[] password = { "raja011", "098765", "RajaRavi" };
            string pattern = @"^[a-zA-Z0-9]{8,}";

            foreach (string input in password)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Password matches", input);
                else
                    Console.WriteLine("{0} User Password Doesn't matches", input);
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
