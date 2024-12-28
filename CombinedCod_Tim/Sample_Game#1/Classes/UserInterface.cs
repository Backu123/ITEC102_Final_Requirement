using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class UserInterface
    {
        public static void Menu()
        {
            string prompt = "5.00 Grades At Johnny's";
            string[] options = { "Start", "About", "Exit" };
            Menu mainMenu = new Menu(options, prompt);
            mainMenu.DisplayOptions();
            int selecttedMenu = mainMenu.SelectedMenu();

            QuizGame quizGame = new QuizGame();
            if (selecttedMenu == 0)
            {
                string prompt2 = "Pick Activity: ";
                string[] options2 = { "Identification", "Multiple Choices", "Output Analysis", "Debugging" };
                Activity_Menu mainMenu2 = new Activity_Menu(options2, prompt2);
                int selectedActivity = mainMenu2.SelectedMenu();
                if (selectedActivity == 0)
                {
                    quizGame.Identification1();
                }
                else if (selectedActivity == 1)
                {
                    quizGame.MultipleChoice1();
                    quizGame.MultipleChoice2();

                }
                else if (selectedActivity == 2)
                {
                    OutputGame.Start();
                }
                else if (selectedActivity == 3)
                {
                    IDE_Game.Start();
                }

            }
            else if (selecttedMenu == 1)
            {
                Console.Clear();
                mainMenu.About();
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Exiting the Program");
                Console.ReadKey();

            }
        }
    }
}
