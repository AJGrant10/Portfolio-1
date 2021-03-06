﻿using System;
//Andrew Grant
//2019 January
//Project & Portfolio 1
//Menu Challenge
//Fixed menu challenge In this challenge I created a welcome menu
namespace DVP1.CE1
{
    class MainClass
    {
        public class  Main(string[] args)
        {
           
    class Menu
    {
        static int menuChoice = 0;


        public static void GetMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("Enter listed number choice");
                Console.WriteLine("");
                Console.WriteLine("[1] Swap Name");
                Console.WriteLine("[2] Backwards");
                Console.WriteLine("[3] Age Convert");
                Console.WriteLine("[4] Temp Convert");
                Console.WriteLine("[5] Big Blue Fish");
                Console.WriteLine("");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter your selected challenge");

                switch (GetMenu(menuChoice))
                {
                    case 1:
                        {
                            Console.Clear();
                            SwapName.GetSwapName();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Backwards.GetBackWards();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            AgeConvert.GetAgeConvert();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            TempConvert.GetTempConvert();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            BigBlueFish.GetBigBlueFish();
                        }
                        break;
                    case 0:
                        {
                            if (menuChoice == 0)
                            {
                                Environment.Exit(0);
                            }
                        }
                        break;

                    default:
                        break;
                }
                
            }
        }

        public static int GetMenu(int menuChoiceInt)
        {
            string menuInput = Console.ReadLine();

            while (!int.TryParse(menuInput, out menuChoiceInt) && menuChoiceInt < 0 && menuChoiceInt > 5)
            {
                Console.WriteLine("Please enter one of the choices in the menu");
            }
            return menuChoiceInt;
        }
    }
} 
        

