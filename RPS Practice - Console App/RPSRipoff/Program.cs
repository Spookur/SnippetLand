using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSRipoff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock Paper Scissors: RIPOFF";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello. Welcome To RPS Ripoff.");
            Console.Write("(Press any key to continue.)");
            Console.CursorVisible = false;

            Console.ReadKey();
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorSize = 100;
            Console.CursorVisible = true;
            
            Console.Write("The Foreground/text color is now blue. Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Choose a number to make a selection: Rock (1), Paper (2), or Scissors (3).");
            

            string userInput = Console.ReadLine();
            int number;
            Int32.TryParse(userInput, out number);

            if (number == 1)
            {
                Console.WriteLine("You've chosen rock.");
                Console.ReadLine();
            }

            if (number == 2)
            {
                Console.WriteLine("You've chosen paper.");
                Console.ReadLine();
            }

            if (number == 3)
            {
                Console.WriteLine("You've chosen scissors.");
                Console.ReadLine();
            }

            if (number == 69)
            {
                DisplayEasterEgg();
            }

            else 
            {
                Console.WriteLine("Please Choose a number between 1 and 3.");
                Console.ReadLine();
            }

        }

        public static void DisplayEasterEgg()
        {
            Console.Beep();
            //Console.SetWindowSize(200,50);
            //Console.SetBufferSize(10000, 10000);
            Console.Clear();
            Console.WriteLine("Congrats!!! You've found the hidden easter egg! You win nothing! :D");
            Console.WriteLine("Press any key to self destruct.");
            Console.ReadLine();
        }

    }
}
