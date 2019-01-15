using System;
//Andrew Grant
//2019 January
//Project & Portfolio 1
//Menu Challenge
namespace DVP1.CE1
{
    class MainClass
    {
        public class  Main(string[] args)
        {
            {
                Console.WriteLine("Coding challenge menu:");
                Console.ReadLine();

                Console.WriteLine("[1]Swap Name");
                Console.WriteLine("[2] Backwards");
                Console.WriteLine("[3] Age Convert");
                Console.WriteLine("[4] Temp Convert");
                Console.WriteLine("[5] Big Blue Fish");

                Console.WriteLine("Please enter the number for the challenge you want to run...");
            }
            
            public static void second(string[] args)
        {
            
            Console.WriteLine("Welcome to SwapName:");
            Console.WriteLine("To begin enter your first name...");
            string inputText = Console.ReadLine();

            Console.WriteLine("Thank you " + inputText + " ,now enter your last name");
            string inputText2 = Console.ReadLine();
            Console.WriteLine("Excellent! Your name is " + inputText + " "+ inputText2 +" reversed would be "+ inputText2 +" " + inputText);
            Console.ReadLine();
        }
        }
    }
}
