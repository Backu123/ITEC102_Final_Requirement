using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sample_Game_1.Classes
{
    public class QuizGame
    {
        public int result = 0;
        public void Start()
        {
            int[] arr = { 0, 1, 2, 3 };
        Random:
            Random ran = new Random();
            int random = ran.Next(1, 5);
            int indexPicker = random - 1;

            if (arr[indexPicker] == 0)
            {
                goto Random;
            }
            if (arr[1] == 0 && arr[2] == 0 && arr[3] == 0)
            {
                return;
            }

            if (indexPicker == arr[1])
            {
                MultipleChoice1();
                arr[1] = 0;
            }
            else if (indexPicker == arr[2])
            {
                MultipleChoice2();
                arr[2] = 0;
            }
            else if (indexPicker == arr[3])
            {
                Identification1();
                arr[3] = 0;
            }

            Console.ReadKey();
            goto Random;
        }
        public int Identification1()
        {
            Console.Clear();
            result = 0; // for return value

            Console.WriteLine("Most common way to output a value or text in C#");
            Console.WriteLine("Console._______();");
            Console.Write("Answer: ");
            string ans = Console.ReadLine();
            string correctAns = "WriteLine";

            // if statement for correct answer
            if (ans.Equals(correctAns))
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.Write($"Console.{ans}();");
                result += 1;
            }
            // if statement for incorrect answers
            else if (ans.Equals(correctAns, StringComparison.OrdinalIgnoreCase))
            {
                // wrong answer
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Red;
                Console.Write($"Console.{ans}();");
                ResetColor();

                // correct answer
                Console.Write(" ");
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Console.{correctAns}();");
                ResetColor();
                Console.WriteLine("Tip: C# is a case-sensitive language. Certain letters are required to be capital or small");
                result += 0;
            }
            else
            {
                // wrong answer
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Red;
                Console.Write($"Console.{ans}();");
                ResetColor();

                // correct answer
                Console.Write(" ");
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Console.{correctAns}();");
                ResetColor();
                Console.WriteLine("Answer: The most common way to output a value is using Console.WriteLine()");
                result += 0;
            }
            Console.ReadKey();
            ResetColor();
            return result;
        }
        public int MultipleChoice1()
        {
            Console.Clear();
        Loop:
            result = 0;
            Console.WriteLine("How do we output a value or text in C#?");
            Console.Write("Console._______();\n");
            string[] option = { "WriteLine", "ReadKey", "ReadLine", "ForegroundColor" };

            Console.WriteLine($"a. {option[0]} \nb. {option[1]}\nc. {option[2]}\nd. {option[3]}");
            Console.Write("Answer: ");
            char ansChar = Convert.ToChar(Console.ReadLine());
            string ans = ansChar.ToString().ToLower();

            if (ans == "a")
            {
                string finalAnswer = $"Console.{option[0]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(finalAnswer);
                result += 1;
            }
            else if (ans == "b")
            {
                string finalAnswer = $"Console.{option[1]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                Console.ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[0]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 0;
            }
            else if (ans == "c")
            {
                string finalAnswer = $"Console.{option[2]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                Console.ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[0]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 0;
            }
            else if (ans == "d")
            {
                string finalAnswer = $"Console.{option[3]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                Console.ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[0]}();";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 0;
            }
            else
            {
                Console.WriteLine("Please input the correct option");
                Console.WriteLine();
                goto Loop;
            }
            Console.ReadKey();
            ResetColor();
            return result;
        }
        public int MultipleChoice2()
        {
            Clear();
        Loop:
            result = 0;
            WriteLine("Syntax that allows a user to input a text in C#?");
            Write("Console._______();\n");
            string[] option = { "WriteLine", "ReadKey", "ReadLine", "ForegroundColor" };

            WriteLine($"a. {option[0]} \nb. {option[1]}\nc. {option[2]}\nd. {option[3]}");
            Write("Answer: ");
            char ansChar = Convert.ToChar(ReadLine());
            string ans = ansChar.ToString().ToLower();

            if (ans == "a")
            {
                string finalAnswer = $"Console.{option[0]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[2]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                WriteLine(rightAnswer);
                result += 0;
            }
            else if (ans == "b")
            {
                string finalAnswer = $"Console.{option[1]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[2]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 0;
            }
            else if (ans == "c")
            {
                string rightAnswer = $"Console.{option[2]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 1;
            }
            else if (ans == "d")
            {
                string finalAnswer = $"Console.{option[3]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Red;
                Console.Write(finalAnswer);
                Console.ResetColor();
                Console.Write(" ");
                string rightAnswer = $"Console.{option[2]}();";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(rightAnswer);
                result += 0;
            }
            else
            {
                Console.WriteLine("Please input the correct option");
                Console.WriteLine();
                goto Loop;
            }
            Console.ReadKey();
            ResetColor();
            return result;
        }
        public int FinalResult()
        {
            return result;
        }
    }
}
