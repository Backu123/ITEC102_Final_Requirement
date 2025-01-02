using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class Header
    {
        public static void display(double grade)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▄");
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                if (i == 0) Console.Write("█");
                else if (i == 1) Console.Write("╔");
                else if (i == Console.WindowWidth - 2) Console.Write("╗");
                else if (i == Console.WindowWidth - 1) Console.Write("█");
                else Console.Write("═");
            }
            Console.WriteLine();


            
            string[] asciiNum = asciiLetter(grade);
            for (int i = 0; i < asciiNum.Length; i++)
            {
                Console.Write("█");
                Console.Write("║");
                for (int spaces = 0; spaces < ((Console.WindowWidth / 2) - (asciiNum[0].Length / 2) - 3); spaces++) { Console.Write(" "); }
                Console.Write(asciiNum[i]);
                for (int spaces = 0; spaces < ((Console.WindowWidth / 2) - (asciiNum[0].Length / 2) - 1); spaces++) { Console.Write(" "); }
                Console.Write("║");
                Console.WriteLine("█");
                //for (int spaces = 0; spaces < ((Console.WindowWidth / 2) - (asciiNum[0].Length / 2) - 10); spaces++) { Console.Write(" "); }
            }

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                if (i == 0) Console.Write("█");
                else if (i == 1) Console.Write("╚");
                else if (i == Console.WindowWidth - 2) Console.Write("╝");
                else if (i == Console.WindowWidth - 1) Console.Write("█");
                else Console.Write("═");
            }
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("▀");
            }
            Console.WriteLine();
        }


        public static string[] asciiLetter(double num)
        {
            //List<string> numBuilder = new List<string>();
            string[] numBuilder = new string[6];
            string givenNum = String.Format("{0:0.00}", num);
            /*Console.WriteLine(givenNum);
            Console.WriteLine(givenNum.Length);*/
            string[] dot ={
                "    "  ,
                "    "  ,
                "    "  ,
                "    "  ,
                "██╗ "  ,
                "╚═╝ "};
            string[] zero ={
                " █████╗ ",
                "██╔═███╗",
                "██║█╔██║",
                "███╔╝██║",
                "╚█████╔╝",
                " ╚════╝ ",};
            string[] one ={
                " ██╗",
                "███║",
                "╚██║",
                " ██║",
                " ██║",
                " ╚═╝",};
            string[] two ={
                "██████╗ ",
                "╚════██╗",
                " █████╔╝",
                "██╔═══╝ ",
                "███████╗",
                "╚══════╝" };
            string[] three ={
                "██████╗ " ,
                "╚════██╗" ,
                " █████╔╝" ,
                " ╚═══██╗" ,
                "██████╔╝" ,
                "╚═════╝ "  };
            string[] four ={
                "██╗  ██╗",
                "██║  ██║" ,
                "███████║" ,
                "╚════██║" ,
                "     ██║" ,
                "     ╚═╝"  };
            string[] five ={
                "███████╗" ,
                "██╔════╝" ,
                "███████╗" ,
                "╚════██║" ,
                "███████║" ,
                "╚══════╝" };
            string[] six ={
                " █████╗ " ,
                "██╔═══╝ " ,
                "██████╗ " ,
                "██═══██╗",
                "╚█████╔╝",
                " ╚════╝ "  };
            string[] seven ={
                "███████╗" ,
                "╚════██║" ,
                "    ██╔╝" ,
                "   ██╔╝ " ,
                "   ██║  " ,
                "   ╚═╝  "  };
            string[] eight ={
                " █████╗ " ,
                "██╔══██╗" ,
                "╚█████╔╝" ,
                "██╔══██╗" ,
                "╚█████╔╝" ,
                " ╚════╝ "  };
            string[] nine ={
                " █████╗ " ,
                "██╔══██╗" ,
                "╚██████║" ,
                " ╚═══██║" ,
                " █████╔╝" ,
                " ╚════╝ " };

            for (int i = 0; i < givenNum.Length; i++)
            {
                if (givenNum[i] == '.') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += dot[j]; } }
                if (givenNum[i] == '0') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += zero[j]; } }
                if (givenNum[i] == '1') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += one[j]; } }
                if (givenNum[i] == '2') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += two[j]; } }
                if (givenNum[i] == '3') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += three[j]; } }
                if (givenNum[i] == '4') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += four[j]; } }
                if (givenNum[i] == '5') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += five[j]; } }
                if (givenNum[i] == '6') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += six[j]; } }
                if (givenNum[i] == '7') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += seven[j]; } }
                if (givenNum[i] == '8') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += eight[j]; } }
                if (givenNum[i] == '9') { for (int j = 0; j < numBuilder.GetLength(0); j++) { numBuilder[j] += nine[j]; } }
            }

            return numBuilder;
        }
        public static void anxiety(int wrongCount)
        {
            int threshold = 5;
            if (wrongCount > threshold) { wrongCount = threshold; }
            double width = Console.WindowWidth;
            for (int i = 0; i < width; i++)
            {
                Console.Write("▄");
            }//░, ▒, ▓
            Console.WriteLine();
            for (int errorBar = 0; errorBar < ((width / threshold) * wrongCount); errorBar++) { Console.Write("░"); }
            Console.WriteLine();
            for (int spaces = 0; spaces < ((width / threshold) * wrongCount); spaces++) { Console.Write("░"); }
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                Console.Write("▀");
            }
        }
        }
    }
