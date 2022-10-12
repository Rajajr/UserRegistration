﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class UserName
    {
        public static void UsersFirstName()
        {
            string[] arr = { "RAJA", "raja","raj145","RAja678","ra24"};
            string pattern = "^[A-Z][a-z]{3}";

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid username",input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid username",input);
                }
            }
        }
    }
}