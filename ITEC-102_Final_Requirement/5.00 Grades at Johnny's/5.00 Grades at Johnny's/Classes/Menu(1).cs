using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sample_Game_1.Classes
{
    
    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string[] options, string prompt)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            AsciiArt.titleArt(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string symbol1 = "";
                string symbol2 = "";


                if (i == SelectedIndex)
                {
                    symbol1 = ">";
                    symbol2 = "<";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    symbol1 = " ";
                    symbol2 = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((currentOption.Length) / 2) -8) + "}", symbol1));
                Console.WriteLine($" {currentOption} {symbol2}");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            bool op = true;
            do
            {
                Console.Clear();
                DisplayOptions();
                bool keyInput = true;
                ConsoleKeyInfo keyInfo = Console.ReadKey(keyInput);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (SelectedIndex <= 0)
                    {
                        SelectedIndex = 0;
                    }
                    else
                    {
                        SelectedIndex--;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex > 2)
                    {
                        SelectedIndex = 2;
                    }
                }
                else if (keyPressed == ConsoleKey.Enter)
                {
                    op = false;
                }
                else
                {
                    keyInput = false;
                }
            } while (op == true);
            return SelectedIndex;
        }

        public int SelectedMenu()
        {
            int selectedMenu = Run();
            return selectedMenu;
        }

        public void About()
        {
            Console.WriteLine("About");
        }
        public void Start()
        {
            QuizGame quizGame = new QuizGame();
            quizGame.Start();
        }


    }
}
