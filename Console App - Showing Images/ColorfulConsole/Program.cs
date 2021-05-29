using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorfulConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\melon.png"));
            Console.ReadLine();
            Console.Clear();

            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\man.jpg"));
            Console.ReadLine();
            Console.Clear();

            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\mon.jpg"));
            Console.ReadLine();
            Console.Clear();

            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\skelly.jpg"));
            Console.ReadLine();
            Console.Clear();

            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\smile.png"));
            Console.ReadLine();
            Console.Clear();

            ConsoleWriteImage(new Bitmap(@"C:\Users\wkelly\Pictures\patrick.png"));
            Console.ReadLine();
            Console.Clear();
        }

        public static int ToConsoleColor(System.Drawing.Color c)
        {
            int index = (c.R > 128 | c.G > 128 | c.B > 128) ? 8 : 0;
            index |= (c.R > 64) ? 4 : 0;
            index |= (c.G > 64) ? 2 : 0;
            index |= (c.B > 64) ? 1 : 0;
            return index;
        }

        public static void ConsoleWriteImage(Bitmap src)
        {
            int min = 39;
            decimal pct = Math.Min(decimal.Divide(min, src.Width), decimal.Divide(min, src.Height));
            Size res = new Size((int)(src.Width * pct), (int)(src.Height * pct));
            Bitmap bmpMin = new Bitmap(src, res);
            for (int i = 0; i < res.Height; i++)
            {
                for (int j = 0; j < res.Width; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)ToConsoleColor(bmpMin.GetPixel(j, i));
                    Console.Write("▀▄");
                    /*or use*/
                    //Console.Write("██");
                }
                System.Console.WriteLine();
            }
        }
    }
}
