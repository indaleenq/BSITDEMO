﻿using System;

namespace BSITDEMO
{

    internal class Program
    {
        static void Main(string[] arg)
        {
            //if (Login()) //if(condition == boolean)
            //{
            //    Console.WriteLine("Welcome!");
            //    Console.WriteLine("Choose from Menu: ");
            //    Console.WriteLine("Enter 0 - to see your profile");
            //    Console.WriteLine("Enter 1 - to update your profile");
            //    Console.WriteLine("Enter 2 - to delete your profile");

            //    int selectedMenu = Convert.ToInt32(Console.ReadLine());

            //    switch (selectedMenu)
            //    {
            //        case 0:
            //            Console.WriteLine("NAME: Bachelor of Science in Information Technology");
            //            Console.WriteLine("BIRTHDATE: " + DateTime.Now.ToShortDateString());
            //            break;
            //        case 1:
            //            Console.WriteLine("UPDATE");

            //            Console.Write("enter your username again.");
            //            string usernameinput2 = Console.ReadLine();
            //            Console.Write("enter your password again.");
            //            string passwordinput2 = Console.ReadLine();

            //            Login();
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect Credentials.");
            //}
        }

        static bool Login()
        {    
            //declare variables for username and password
            string username = "bsit";
            string password = "bsit";

            Console.Write("Enter your username:");
            string usernameInputted = Console.ReadLine();

            Console.Write("Enter your password: ");
            string passwordInputted = Console.ReadLine();

            bool result = usernameInputted == username && passwordInputted == password
                            ? true : false;

           
            return result;
        }
    }

   
}
