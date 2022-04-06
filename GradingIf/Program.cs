using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam result:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper()); //char - контейнер для одной буквы toupper или tolower перевод
                                                                           //букв в верхний или нижний регистр

            //A - Outstanding B - Superior C - Good D - Satisfactory E - Low Pass F - Failure 


            if (userInput == 'A') //тут обязательно в одни ковычки ' '
            {
                Console.WriteLine("Outstanding");
            }
            else if (userInput == 'B')
            {
                Console.WriteLine("Superior");
            }
            else if (userInput == 'C')
            {
                Console.WriteLine("Good");
            }
            else if (userInput == 'D')
            {
                Console.WriteLine("Satisfactory");
            }
            else if (userInput == 'E')
            {
                Console.WriteLine("Low Pass");
            }
            else if (userInput == 'F')
            {
                Console.WriteLine("Failure");
            }
            else
            {
                Console.WriteLine("This isnt an exam result");
            }

            Console.WriteLine("Have a nice day.");
        }
    }
}
