using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    internal class Activity_Menu
    {
        private int SelectedIndex;
        private string[] Options2;
        private string Prompt2;
        public Activity_Menu(string[] options2, string prompt2)
        {
            Options2 = options2;
            Prompt2 = prompt2;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt2);
            for (int i = 0; i < Options2.Length; i++)
            {
                string currentOption = Options2[i];
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
                Console.WriteLine($"{symbol1} {currentOption} {symbol2}");
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
                    if (SelectedIndex > 3)
                    {
                        SelectedIndex = 3;
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

    }
}
