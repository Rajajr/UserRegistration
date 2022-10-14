using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    class UserName
    {
        public static void UsersFirstName()
        {
            
            string[] arr = { "Raja", "raja", "ra24", "RAja678" };
            string pattern = "^[A-Z][a-z]{3}";

            foreach(string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Fist Name matches", input);
                else
                    Console.WriteLine("{0} User First Name Doesn't matches",input);
                Console.WriteLine("-------------------------------------------------");
            }

        }
        public static void UserLastName()
        {
            string[] arr = { "Ravi", "ravi", "ra24", "RAvi678" };
            string pattern = "^[A-Z][a-z]{3}";

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
            string[] arr = { "rajjr011@gmail.com","rajJR011@GMAIL","raJAjr234@gmail.com"};
            string pattern = @"^[a-z0-9_\-\.]+[@][a-z]+[\.][a-z]{3,}";

            foreach(string input in arr)
            {
                if (Regex.IsMatch(input, pattern))

                    Console.WriteLine("{0} User Email matches", input);
                else
                    Console.WriteLine("{0} User Email Doesn't matches", input);
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
