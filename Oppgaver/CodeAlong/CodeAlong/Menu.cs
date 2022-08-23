//using Figgle;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TexAd
//{
//    internal class Menu
//    {
//        public static void Start()
//        {
//            Console.WriteLine(FiggleFonts.Graffiti.Render("Frank <3 boys!"));
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using static System.Console;

namespace TexAd
{
    internal class Menu
    {
        public string Examples;
        public string[] Options;
        public int Select;



        public Menu(int select, string[] options, string examples)
        {

            Options = options;
            Examples = examples;
            Select = 0;
        }

        public void ShowOptions()
        {
            WriteLine(Examples);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOptions = Options[i];
                string foran;
                if (i == Select)
                {
                    foran = " ";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    foran = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{foran}<<<{currentOptions}>>>");
            }
            ResetColor();
        }

        public static void startMenu()
        {

            string foran = "";
            string[] options = { "Play", "About", "Settings", "Exit" };
            Menu mainMenu = new Menu(0, options, foran);
            int Select = mainMenu.Run();
            mainMenu.ShowOptions();
            switch (Select)
            {
                case 0:
                    Clear();
                    StartGame1();
                    break;
                case 1:
                    Clear();
                    About();
                    startMenu();
                    break;

                case 2:
                    Settings();
                    WriteLine("Random line of text");
                    startMenu();
                    break;

                case 3:
                    Exit();
                    Clear();
                    break;
            }
            Clear();
        }

        public static void Exit()
        {
            WriteLine("Press any key to exit.");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static void Settings()
        {
            WriteLine("Nothing to see here");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static void About()
        {
            WriteLine("");
            ReadKey(true);
            WriteLine();
            startMenu();
        }

        public static void StartGame1()
        {
            //GameCharacters.StartGame();
            //GameCharacters.Player();
            Game.Play();
            ReadKey(true);
        }

        public int Run()
        {
            ConsoleKey pressed;
            do
            {
                Clear();
                Console.WriteLine(FiggleFonts.Graffiti.Render("Frank <3 boys!"));
                ShowOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                pressed = keyInfo.Key;
                if (pressed == ConsoleKey.UpArrow)
                {
                    Select--;
                    if (Select == -1)
                    {
                        Select = Options.Length - 1;
                    }

                }
                else if (pressed == ConsoleKey.DownArrow)
                {
                    Select++;
                    if (Select == Options.Length)
                    {
                        Select = 0;
                    }
                }
            } while (pressed != ConsoleKey.Enter);

            return Select;
        }
    }
}
