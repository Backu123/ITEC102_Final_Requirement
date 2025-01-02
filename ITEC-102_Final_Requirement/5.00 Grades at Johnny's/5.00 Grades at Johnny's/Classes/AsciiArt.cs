using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class AsciiArt
    {
        public static void titleArt(int spacingAbove, int spacingBetween, int spacingBelow)
        {

            string[] five = {
            "███████╗    ██████╗  ██████╗ ",
            "██╔════╝   ██╔═████╗██╔═████╗",
            "███████╗   ██║██╔██║██║██╔██║",
            "╚════██║   ████╔╝██║████╔╝██║",
            "███████║██╗╚██████╔╝╚██████╔╝",
            "╚══════╝╚═╝ ╚═════╝  ╚═════╝ "
            };

            string[] num = {
            "1",
            "123",
            "12345",
            "1234567",
            "123456789" };

            string[] lettering = {
            " ██████╗ ██████╗  █████╗ ██████╗ ███████╗███████╗     █████╗ ████████╗         ██╗ ██████╗ ██╗  ██╗███╗   ██╗███╗   ██╗██╗   ██╗███████╗",
            "██╔════╝ ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝    ██╔══██╗╚══██╔══╝         ██║██╔═══██╗██║  ██║████╗  ██║████╗  ██║╚██╗ ██╔╝██╔════╝",
            "██║  ███╗██████╔╝███████║██║  ██║█████╗  ███████╗    ███████║   ██║            ██║██║   ██║███████║██╔██╗ ██║██╔██╗ ██║ ╚████╔╝ ███████╗",
            "██║   ██║██╔══██╗██╔══██║██║  ██║██╔══╝  ╚════██║    ██╔══██║   ██║       ██   ██║██║   ██║██╔══██║██║╚██╗██║██║╚██╗██║  ╚██╔╝  ╚════██║",
            "╚██████╔╝██║  ██║██║  ██║██████╔╝███████╗███████║    ██║  ██║   ██║       ╚█████╔╝╚██████╔╝██║  ██║██║ ╚████║██║ ╚████║   ██║   ███████║",
            " ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚══════╝    ╚═╝  ╚═╝   ╚═╝        ╚════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝" };


            /*int previousWidth = 0;
            int previousHeight = 0;
            while (true)
            {
                int screenWidth = Console.WindowWidth;
                int screenHeight = Console.WindowWidth;
               
                int center = (screenWidth / 2) + screenHeight / 2;
                int lowercenter = (screenWidth / 2) + ((screenHeight / 2) - 4);

                if (previousWidth != screenWidth)
                {
                    Console.Clear();
                    for (int i = 0; i < five.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (five[i].Length / 2)) + "}", five[i])); }
                    Console.WriteLine();
                    for (int i = 0; i < num.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (num[i].Length / 2)) + "}", num[i])); }
                    Console.WriteLine();
                    for (int j = 0; j < lettering.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2 ) + (lettering[j].Length / 2)) + "}", lettering[j])); };
                }
                
                previousWidth = screenWidth;
                previousHeight = screenHeight;
            }*/


            int screenWidth = Console.WindowWidth;
            int screenHeight = Console.WindowWidth;

            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < five.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (five[i].Length / 2)) + "}", five[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < lettering.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (lettering[j].Length / 2)) + "}", lettering[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ResetColor();
        }
    }
}
