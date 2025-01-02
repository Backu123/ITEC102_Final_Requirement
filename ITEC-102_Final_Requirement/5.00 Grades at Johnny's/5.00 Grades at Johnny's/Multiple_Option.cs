using Sample_Game_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1
{
    internal class Multiple_Option
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        public int result = 0;

        public Multiple_Option(string[] options, string prompt)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine($"{currentOption}");
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
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

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
            Console.WriteLine(selectedMenu);
            return selectedMenu;
        }
    }
}
