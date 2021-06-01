using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDManager.View
{
    public class inputOutput
    {
        public int GetInteger()
        {
            bool validInput = false;
            int _id = 0;

            while (!validInput)
            {
                Console.Clear();
                Console.WriteLine("Please enter an ID:");
                if(int.TryParse(Console.ReadLine(), out _id))
                {
                    Console.WriteLine("You chose "+ _id);
                    Console.ReadKey();
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                
            }

            return _id;
        }

        public string GetTitle()
        {
            bool validInput = false;
            string _title = "";

            while(!validInput)
            {
                Console.Clear();
                Console.WriteLine("Please choose a title for your creation:");
                _title = Console.ReadLine();
                Console.WriteLine("You chose "+ _title);
                Console.ReadKey();
                validInput = true;
                
            }

            return _title;

        }

        public string GetDescription()
        {
            bool validInput = false;
            string _description = "";

            while(!validInput)
            {
                Console.Clear();
                Console.WriteLine("Please choose a description for your creation:");
                _description = Console.ReadLine();
                Console.WriteLine("You chose "+ _description);
                Console.ReadKey();
                validInput = true;
            }

            return _description;
        }
    }
}
