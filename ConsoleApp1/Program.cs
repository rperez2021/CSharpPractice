using System;


namespace ConsoleApp1
{
    internal class Program
    {   
        // Entry point of program
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Enter a String and Press Enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("Enter a Character to Search and Press Enter:");
            string searchInput = Console.ReadLine();
            Console.WriteLine("This letter can be found at index: " + readInput.IndexOf(searchInput));
            Console.WriteLine("By the way... whats your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + lastName;
            Console.WriteLine("Nice to meet you {0}", fullName);
            Console.Read();

            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Robert!");
            
            int aNumber = 5;
            Console.WriteLine(aNumber);
            float pi = 3.1415f;
            Console.WriteLine(pi);
            bool areYouCool = true;
            Console.WriteLine(areYouCool);
            string myName = "Robert";
            Console.WriteLine(myName);
            char at = '@';
            Console.WriteLine(at);
            Console.ForegroundColor = ConsoleColor.Blue;
            int num1 = 13;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + " + "num2: " + num2 + " = " + sum);
            
            int num3 = 100, num4 = 500, num5 = 200;
            int sum2 = num3 + num4 + num5;
            Console.WriteLine(sum2);
            double double1 = 5.0112545;
            Console.WriteLine(double1);
            long long1 = 181516565454513;
            Console.WriteLine(long1);
            Console.WriteLine("HELLO WELCOME!");
            Console.Write("HELLO WELCOME!");

            //String Lesson

            Console.Write("Enter a String and Press Enter:");
            Console.WriteLine("You have entered {0}",readInput);

            Console.Write("Enter a String and Press Enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            Console.ReadKey();
            
        }
    }
}
