using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-5 User need to follow pre-defined password rules.
            Console.WriteLine("Welcome to User Registration");


            //UserName.UsersFirstName();
            //UserName.UserLastName();
            //UserName.Email();
            //UserName.PhoneNumber();
            UserName.Password();
            Console.ReadLine();
        }
    }
}
