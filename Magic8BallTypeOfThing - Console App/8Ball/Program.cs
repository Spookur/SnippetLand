using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gamePlay = true;

            while (gamePlay)
            {
                Console.WriteLine();
                Console.Write("Enter 'w' to get a dare. Enter 'e' to close the app.");
                Console.WriteLine();
                Console.CursorSize = 50;

                string userInput = Console.ReadLine().ToLower();
                int randomDare = new Random().Next(0,21);
                

                if (userInput == "w")
                {
                    Console.Clear();
                    switch (randomDare)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Hanging Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pantsed Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Shoulder Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Messy Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Regular Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Jock Lock");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("10 Hard Spankings and a Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 7:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Atomic Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 8:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nip Clamps and hard wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 9:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wet willy and hard wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 10:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Squeaky Clean");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 11:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Frontal Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 12:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ice Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 13:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Double Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 14:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Doorknob Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 15:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Dangling Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 16:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tarzan Wedgie");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 17:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Poop Accident");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 18:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pee Accident");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                        case 19:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("50 spankings");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You get lucky.");
                            Console.WriteLine();
                            Console.ResetColor();
                            break;

                    }

                    // array
                    string[] color = { "Red", "Blue", "White", "Purple", "Cyan", "Yellow", "Green", "Orange", "Pink" };
                    string[] style = { "Bikini Panties", "Bikini", "Hipsters", "Thong", "Cheekies", "Granny Panties", "Briefs", "Tanga", "Panties" };
                    string[] clothing = { "a Tee Shirt and Jeans", "a Tee Shirt and Shorts", "just a Bra & Panties", "a bodysuit", "Sweatpants and a Cami/Tank", "Jean Shorts and a Tee", "a Skirt", "a Dress", "nothing" };
                    // Create a Random object  
                    Random rand = new Random();
                    // Generate a random index less than the size of the array.  
                    int indexColor = rand.Next(color.Length);
                    int indexStyle = rand.Next(style.Length);
                    int indexClothing = rand.Next(clothing.Length);
                    // Display the result.  
                    Console.WriteLine("in " + color[indexColor] + " " + style[indexStyle]);
                    Console.WriteLine();
                    Console.WriteLine("wearing " + clothing[indexClothing]);



                }

                if (userInput !="w" && userInput != "e")
                {
                    Console.Clear();
                }

                if (userInput == "e")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing ;)... press any key to close the app.");
                    Console.ReadLine();
                    gamePlay = false;
                }

                if (userInput == "longplay")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the long version of the game. Press any key to continue.");
                    Console.ReadKey();

                    
                }
            }     
        }
    }
}
