using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam result:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (userInput)
            {
                case 'A':
                    Console.WriteLine("Outstanding");
                    break; // это слово позволяет выйти из блока
                case 'B':
                    Console.WriteLine("Superior");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'E':
                    Console.WriteLine("Low Pass");
                    break;
                case 'F':
                    Console.WriteLine("Failure");
                    break;
                default:
                    Console.WriteLine("This isnt an exam result");
                    break;
            }

            Console.WriteLine("Have a nice day.");
        }
    }
}
//A - Outstanding B - Superior C - Good D - Satisfactory E - Low Pass F - Failure 

