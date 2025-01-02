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

            
            if (selecttedMenu == 0)
            {
                Console.Clear();
                semesterOne.start();

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
