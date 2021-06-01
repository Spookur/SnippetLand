using AudioSwitcher.AudioApi.CoreAudio;
using CRUDManager.Data;
using CRUDManager.Models;
using CRUDManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Media;

namespace CRUDManager.Controller
{
    public class CRUDController
    {
        bool gameOn;
        CRUDView view;
        CRUDRepo repo;


        public CRUDController()
        {
            view = new CRUDView();
            repo = new CRUDRepo();

        }
        public void Run()
        {
            gameOn = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello Human");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("I have been waiting here for far too long.");
            Console.Beep();
            Console.ReadLine();

            while(gameOn == true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to CRUD Manager. Create/Read/Update/Delete stuff with this application.");
                Console.WriteLine();
                Console.WriteLine("1. Create ");
                Console.WriteLine("2. List All ");
                Console.WriteLine("3. Read By ID ");
                Console.WriteLine("4. Update ");
                Console.WriteLine("5. Delete ");
                Console.WriteLine("6. View System Settings ");
                Console.WriteLine("7. Adjust Volume");
                Console.WriteLine("8. Exit Application");
                Console.WriteLine();
                Console.Write("What is your choice?  ");

                int menuChoice;

                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch(menuChoice)
                    {
                        case 1:
                            CreateSomething();
                            break;
                        case 2:
                            DisplayAll();
                            break;
                        case 3:
                            Console.WriteLine("Read By ID");
                            break;
                        case 4:
                            Console.WriteLine("Edit");
                            break;
                        case 5:
                            Console.WriteLine("Delete");
                            break;
                        case 6:
                            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Current Volume: " + defaultPlaybackDevice.Volume);
                            Console.WriteLine();
                            ConsoleHelper.SetCurrentFont("Monospace", 20);
                            Console.ReadLine();
                            break;
                        case 7:
                            bool validInput = true;
                            int volumeControl;
                            while(validInput == true)
                            {
                                CoreAudioDevice currentVolume = new CoreAudioController().DefaultPlaybackDevice;
                                Console.Clear();
                                Console.WriteLine("The current volume is: " + currentVolume.Volume);
                                Console.WriteLine();
                                Console.WriteLine("How loud do you want the volume? (Choose a number between 0-100) Choosing '0' will mute the music.");
                                if (int.TryParse(Console.ReadLine(), out volumeControl))
                                {
                                    Console.WriteLine("You chose: " + volumeControl);
                                    currentVolume.Volume = Convert.ToDouble(volumeControl);
                                    Console.Clear();
                                    Console.WriteLine("The current volume is now: " + currentVolume.Volume);

                                    Console.ReadLine();
                                    validInput = false;
                                }

                                else
                                {

                                    Console.WriteLine("Invalid input");
                                }
                            }
                            
                            break;
                        case 8:
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "STRANGETOWN.wav";
                            player.Play();
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Console.WriteLine("Initiate Self-Destruct Sequence...");
                            Console.ReadLine();
                            gameOn = false;
                            break;

                        default:
                            Console.WriteLine();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }

        public void CreateSomething()
        {
            CRUD crud = view.Create();
            repo.Create(crud);
        }

        public void DisplayAll()
        {
            List<CRUD> crudList = repo.ReadAll();
            Console.Clear();

            if(crudList.Count == 0)
            {
                Console.WriteLine("There are no creations! MAKE SOME, HUMAN!!");
                Console.ReadLine();
            }

            else
            {
                for (int i = 0; i < crudList.Count; i++)
                {
                    view.DisplayCRUD(crudList[i]);
                    
                }

                Console.ReadLine();
            }
        }

        public class ConsoleHelper
        {
            private const int FixedWidthTrueType = 54;
            private const int StandardOutputHandle = -11;

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern IntPtr GetStdHandle(int nStdHandle);

            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);

            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            internal static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool MaximumWindow, ref FontInfo ConsoleCurrentFontEx);


            private static readonly IntPtr ConsoleOutputHandle = GetStdHandle(StandardOutputHandle);

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            public struct FontInfo
            {
                internal int cbSize;
                internal int FontIndex;
                internal short FontWidth;
                public short FontSize;
                public int FontFamily;
                public int FontWeight;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
                //[MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.wc, SizeConst = 32)]
                public string FontName;
            }

            public static FontInfo[] SetCurrentFont(string font, short fontSize = 0)
            {
                Console.WriteLine("The Current Font Is: " + font);


                FontInfo before = new FontInfo
                {
                    cbSize = Marshal.SizeOf<FontInfo>()
                };

                if (GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref before))
                {

                    FontInfo set = new FontInfo
                    {
                        cbSize = Marshal.SizeOf<FontInfo>(),
                        FontIndex = 0,
                        FontFamily = FixedWidthTrueType,
                        FontName = font,
                        FontWeight = 400,
                        FontSize = fontSize > 0 ? fontSize : before.FontSize
                    };

                    // Get some settings from current font.
                    if (!SetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref set))
                    {
                        var ex = Marshal.GetLastWin32Error();
                        Console.WriteLine("Set error " + ex);
                        throw new System.ComponentModel.Win32Exception(ex);
                    }

                    FontInfo after = new FontInfo
                    {
                        cbSize = Marshal.SizeOf<FontInfo>()
                    };
                    GetCurrentConsoleFontEx(ConsoleOutputHandle, false, ref after);

                    return new[] { before, set, after };
                }
                else
                {
                    var er = Marshal.GetLastWin32Error();
                    Console.WriteLine("Get error " + er);
                    throw new System.ComponentModel.Win32Exception(er);
                }
            }
        }
    }
}
