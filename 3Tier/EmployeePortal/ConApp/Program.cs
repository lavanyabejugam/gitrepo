using System;
using DomainLayer.Models;
using BusinessLayer;
namespace ConApp
{
    class Program
    {

        static void Main(string[] args)
        {

            Authentication authentication = new Authentication();Console.WriteLine("enter");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    authentication.Login();
                    break;
                case 2:
                    authentication.Register();
                    break;
            }

            Console.ReadLine();
        }
    }
}
