using System;
using System.IO;

namespace L6._6_popularNameSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Popular Girls Name Search.");
            Console.WriteLine("===========================");

            // Enter your file reading (StreamReader) codes  here

            

            while (true)
            {
                Console.Write("Enter Girl's name to search: ");
                string girlName = Console.ReadLine();

                //Enter you search codes here




                Console.Write("Do you wish to search another name (Y/N)?");
                char response = Char.Parse(Console.ReadLine());
                if (char.ToUpper(response)=='N')
                {
                    break;
                }
            }


        }
    }
}
