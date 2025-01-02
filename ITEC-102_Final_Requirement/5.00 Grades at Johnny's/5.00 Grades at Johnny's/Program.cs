using Sample_Game_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sample_Game_1
{
   
    internal class Program 
    {
        static void Main(string[] args)
        {
            AsciiArt.titleArt(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ForegroundColor = ConsoleColor.Red;
            string enter = "Enter a Key to Play....";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (enter.Length / 2)) + "}", enter));
            Console.ResetColor();
            Console.ReadKey();
            UserInterface.Menu();
            ResetColor();
        }
    }
}
