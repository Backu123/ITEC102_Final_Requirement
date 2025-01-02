using Sample_Game_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sample_Game_1
{
    internal class Quizzes
    {
    }
    internal class Activity_1
    {
        private int anxietyCounter = 0;
        private int result = 0;
        public void Ascii_Act1(int spacingAbove, int spacingBetween, int spacingBelow)
        {
            string[] numBuilder = new string[6];
            string[] ascii_act1 =
            {
            " █████╗  ██████╗████████╗██╗██╗   ██╗██╗████████╗██╗   ██╗     ██╗",
            "██╔══██╗██╔════╝╚══██╔══╝██║██║   ██║██║╚══██╔══╝╚██╗ ██╔╝    ███║",
            "███████║██║        ██║   ██║██║   ██║██║   ██║    ╚████╔╝     ╚██║",
            "██╔══██║██║        ██║   ██║╚██╗ ██╔╝██║   ██║     ╚██╔╝       ██║",
            "██║  ██║╚██████╗   ██║   ██║ ╚████╔╝ ██║   ██║      ██║        ██║",
            "╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝        ╚═╝"
            };
            string[] ascii_click =
            {
            @"                                   _                _                          _   _                  ",
            @"                                  | |              | |                        | | (_)                 ",
            @" _ __  _ __ ___  ___ ___    __ _  | | _____ _   _  | |_ ___     ___ ___  _ __ | |_ _ _ __  _   _  ___ ",
            @"| '_ \| '__/ _ \/ __/ __|  / _` | | |/ / _ \ | | | | __/ _ \   / __/ _ \| '_ \| __| | '_ \| | | |/ _ \",
            @"| |_) | | |  __/\__ \__ \ | (_| | |   <  __/ |_| | | || (_) | | (_| (_) | | | | |_| | | | | |_| |  __/",
            @"| .__/|_|  \___||___/___/  \__,_| |_|\_\___|\__, |  \__\___/   \___\___/|_| |_|\__|_|_| |_|\__,_|\___|",
            @"| |                                          __/ |                                                    ",
            @"|_|                                         |___/                                                     "
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < ascii_act1.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_act1[i].Length / 2)) + "}", ascii_act1[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < ascii_click.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_click[j].Length / 2)) + "}", ascii_click[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ReadKey();
        }
        public int Multiple_Choices2()
        {
            string prompt = "What programming language developed by Microsoft that runs on the .NET Framework?";
            string[] options = { "a. Python", "b. C#", "c. Java", "d. C++" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                result += 0;

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
               
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                result += 1;

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }
        public int Multiple_Choices1()
        {
            string prompt = "What programming generation uses Machine Language?";
            string[] options = { "a. 1st Generation", "b. 2nd Generation", "c. 3rd Generation", "d. 4th Generation" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                result += 1;
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
            }
            else if (selecttedMenu == 1)
            {
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }

        public int Multiple_Choices3()
        {
            string prompt = "It is a skill that involves writing computer programs for various purposes.";
            string[] options = { "a. Writing", "b. Computers and Electronics", "c. Programming", "d. Writing" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }
        public int Multiple_Choices8()
        {
            string prompt = "These are phases which involves with creating a project development.";
            string[] options = { "a. Pseudocode", "b. SDLC", "c. PDLC", "d. Flowcharting" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }
        public int Multiple_Choices10()
        {
            string prompt = "This Control Structure is also known as Iteration Control Structure.";
            string[] options = { "a. Sequence Control Structure", "b. Selection Control Structure", "c. Repetition Control Structure", "d. Repetentive Control Structure" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Console.Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[2]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }
        
        public void Arrangement()
        {
            Multiple_Choices3();
            Multiple_Choices1();
            Multiple_Choices2();
            Multiple_Choices10();
            Multiple_Choices8();
        }
        public double Result()
        {
            double grade = Evaluation.Percentage(5, result);
            Clear();
            return grade;
        }

    }
    internal class Activity_2
    {
        private int result = 0;
        public void Ascii_Act(int spacingAbove, int spacingBetween, int spacingBelow)
        {
            string[] numBuilder = new string[6];
            string[] ascii_act =
            {
            " █████╗  ██████╗████████╗██╗██╗   ██╗██╗████████╗██╗   ██╗    ██████╗ ",
            "██╔══██╗██╔════╝╚══██╔══╝██║██║   ██║██║╚══██╔══╝╚██╗ ██╔╝    ╚════██╗",
            "███████║██║        ██║   ██║██║   ██║██║   ██║    ╚████╔╝      █████╔╝",
            "██╔══██║██║        ██║   ██║╚██╗ ██╔╝██║   ██║     ╚██╔╝      ██╔═══╝ ",
            "██║  ██║╚██████╗   ██║   ██║ ╚████╔╝ ██║   ██║      ██║       ███████╗",
            "╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝       ╚══════╝"
            };
            string[] ascii_click =
            {
            @"                                   _                _                          _   _                  ",
            @"                                  | |              | |                        | | (_)                 ",
            @" _ __  _ __ ___  ___ ___    __ _  | | _____ _   _  | |_ ___     ___ ___  _ __ | |_ _ _ __  _   _  ___ ",
            @"| '_ \| '__/ _ \/ __/ __|  / _` | | |/ / _ \ | | | | __/ _ \   / __/ _ \| '_ \| __| | '_ \| | | |/ _ \",
            @"| |_) | | |  __/\__ \__ \ | (_| | |   <  __/ |_| | | || (_) | | (_| (_) | | | | |_| | | | | |_| |  __/",
            @"| .__/|_|  \___||___/___/  \__,_| |_|\_\___|\__, |  \__\___/   \___\___/|_| |_|\__|_|_| |_|\__,_|\___|",
            @"| |                                          __/ |                                                    ",
            @"|_|                                         |___/                                                     "
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < ascii_act.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_act[i].Length / 2)) + "}", ascii_act[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < ascii_click.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_click[j].Length / 2)) + "}", ascii_click[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ReadKey();
        }

        public void Arrangement()
        {
            Fill_Question2(); // while loop
            Fill_Question3(); // string
            Fill_Value2(); // integer
            Given1(); // 4
            Given2(); // 4
        }
        
        public int Fill_Question2()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            Console.WriteLine("Fill the missing keyword:");
            Console.WriteLine(@"
int num = 0;
do
{
    Console.Write(num);
    num++;
}______(num < 5);
");
            Console.Write("Answer: ");
            string ans = Console.ReadLine();
            string answer = ans.Trim();
            string correctAnswer = "while";

            Console.WriteLine();
            if (answer.Equals(correctAnswer))
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write("(num < 5);" + "\n");
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine("(num < 5);" + "\n");
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(num < 5);");
                Console.WriteLine("\n");
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
            }
            else
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine("(num < 5);" + "\n");
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(num < 5);");
                Console.WriteLine("\n");
                result += 0;
            }
            
            Console.ReadKey();
            ResetColor();
            return result;
        }

        // datatypes
        public int Fill_Question3()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            Console.WriteLine("Fill in the missing keyword:");
            Console.WriteLine(@"_____ word = ""Hello World"";");
            Console.Write("Answer: ");
            string ans = Console.ReadLine();
            string answer = ans.Trim();

            string correctAnswer1 = "String";
            string correctAnswer2 = "string";

            if (answer.Equals(correctAnswer1) || answer.Equals(correctAnswer2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" word = ""Hello World"";");
                result += 1;
            }
            else if (answer.Equals(correctAnswer1, StringComparison.OrdinalIgnoreCase) || answer.Equals(correctAnswer2, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" word = ""Hello World"";");

                Console.WriteLine();
                Console.WriteLine("Correct Answer: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer1);
                ResetColor();
                Console.Write(@" word = ""Hello World""; or ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer2);
                ResetColor();
                Console.WriteLine(@" word = ""Hello World"";");
                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
                ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" word = ""Hello World""");

                Console.WriteLine();
                Console.WriteLine("Correct Answer:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer1);
                ResetColor();
                Console.Write(@" word = ""Hello World"" or ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer2);
                ResetColor();
                Console.WriteLine(@" word = ""Hello World""");
                result += 0;

                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("String");
                ResetColor();
                Console.WriteLine($" is a datatype that is used to store a series of characters. Ex: Hello");
            }
            Console.ReadKey();
            Clear();
            return result;
        }

        // value of datatypes
        public int Fill_Value2()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine("Input the correct value:");
                Console.WriteLine(@"int value = _______ ;");
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());

                Console.Write("int value = ");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write(";");
                result += 1;
                Console.ReadKey();
                Clear();
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Your answer is not an Integer.");
                ForegroundColor = ConsoleColor.Blue;
                Console.Write("Integer ");
                ResetColor();
                Console.WriteLine("is a datatype that stores whole numbers like 1, 35, 176");
                result += 0;
            }
            Console.ReadKey();
            Clear();
            return result;
        }

        public int Given1()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            Console.WriteLine("Enter the Output of the ff code:\n");
            string given1 = "int a = 5;\r\nint b = 3;\r\nif ((a = 7) == b)\r\n    Console.WriteLine(a + b);\r\nelse\r\n    Console.WriteLine(a - b);";

            int a = 5;
            int b = 3;
            int right = 0;
            if ((a = 7) == b)
                right = a + b;
            else
                right = a - b;
            try
            {
                Console.WriteLine($"{given1}");
                int correctAnswer = right;
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);

                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine($"{given1}");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine($"{given1}");
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }
        public int Given2()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            string given = $"int x = 1;\r\nConsole.WriteLine(x++ + ++x);";
            int x = 1;
            int correctAnswer = x++ + ++x;
            try
            {
                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);

                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }

        // result
        public double Result()
        {
            double grade = Evaluation.Percentage(5, result);
            Clear();
            return grade;
        }
    }
    internal class Midterms
    {
        private int result = 0;
        public void Ascii_Act(int spacingAbove, int spacingBetween, int spacingBelow)
        {
            string[] numBuilder = new string[6];
            string[] ascii_act =
            {
            "███╗   ███╗██╗██████╗ ████████╗███████╗██████╗ ███╗   ███╗███████╗",
            "████╗ ████║██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗████╗ ████║██╔════╝",
            "██╔████╔██║██║██║  ██║   ██║   █████╗  ██████╔╝██╔████╔██║███████╗",
            "██║╚██╔╝██║██║██║  ██║   ██║   ██╔══╝  ██╔══██╗██║╚██╔╝██║╚════██║",
            "██║ ╚═╝ ██║██║██████╔╝   ██║   ███████╗██║  ██║██║ ╚═╝ ██║███████║",
            "╚═╝     ╚═╝╚═╝╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝"
            };
            string[] ascii_click =
            {
            @"                                   _                _                          _   _                  ",
            @"                                  | |              | |                        | | (_)                 ",
            @" _ __  _ __ ___  ___ ___    __ _  | | _____ _   _  | |_ ___     ___ ___  _ __ | |_ _ _ __  _   _  ___ ",
            @"| '_ \| '__/ _ \/ __/ __|  / _` | | |/ / _ \ | | | | __/ _ \   / __/ _ \| '_ \| __| | '_ \| | | |/ _ \",
            @"| |_) | | |  __/\__ \__ \ | (_| | |   <  __/ |_| | | || (_) | | (_| (_) | | | | |_| | | | | |_| |  __/",
            @"| .__/|_|  \___||___/___/  \__,_| |_|\_\___|\__, |  \__\___/   \___\___/|_| |_|\__|_|_| |_|\__,_|\___|",
            @"| |                                          __/ |                                                    ",
            @"|_|                                         |___/                                                     "
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < ascii_act.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_act[i].Length / 2)) + "}", ascii_act[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < ascii_click.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_click[j].Length / 2)) + "}", ascii_click[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ReadKey();
        }

        public int Multiple_Choices4()
        {
            string prompt = "What is a set of instructions that follows the rules of the chosen language?";
            string[] options = { "a. Programming Language", "b. Computer Programming", "c. Computer Programmer", "d. Computer Program" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);

                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 1;
            }
            Console.ReadKey();
            return result;
        }//
        public int Multiple_Choices5()
        {
            string prompt = "It is an ability to communicate information and ideas in speaking so others will understand.";
            string[] options = { "a. Mathematics", "b. Oral Expression", "c. Oral Comprehension", "d. Written Expression" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }//
        public int Multiple_Choices6()
        {
            string prompt = "These are computer languages that can be understood by the users; similar to human language.";
            string[] options = { "a. Average Level Language", "b. Middle Level Language", "c. Low Level Language", "d. High Level Language" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 1;
            }
            Console.ReadKey();
            return result;
        }//
        public int Multiple_Choices7()
        {
            string prompt = "This language's instructions are only written in the form of binary numbers, 1’s and 0’s.";
            string[] options = { "a. Low Level Language", "b. Middle Level Language", "c. Average Level Language", "d. High Level Language" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[0]);
                ResetColor();
                Console.WriteLine(options[1]);
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                result += 0;
            }
            Console.ReadKey();
            return result;
        }//
        public int Multiple_Choices9()
        {
            string prompt = "Which phase of the PDLC does the problem carefully considered and the program specifications developed?";
            string[] options = { "a. Project Design", "b. Problem Analysis", "c. Debugging", "d. Coding" };
            Multiple_Option quiz = new Multiple_Option(options, prompt);
            int selecttedMenu = quiz.SelectedMenu();
            if (selecttedMenu == 0)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[0]);
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 1)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                Console.WriteLine(options[3]);
                result += 1;
            }
            else if (selecttedMenu == 2)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[2]);
                ResetColor();
                Console.WriteLine(options[3]);
                result += 0;
            }
            else if (selecttedMenu == 3)
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine(prompt);
                Console.WriteLine(options[0]);
                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[1]);
                ResetColor();
                Console.WriteLine(options[2]);
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(options[3]);
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            return result;
        }
        public int Fill_Question1()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill in the missing keyword:");
            Console.WriteLine("______.ReadKey();");
            Console.Write("Answer: ");
            string answer = Console.ReadLine().Trim();
            string correctAnswer = "Console";

            if (answer.Equals(correctAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine($".ReadKey();");
                result += 1;
                ResetColor();
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write($".ReadKey();");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.WriteLine($".ReadKey();");
                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
                ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write($".ReadKey();");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write($".ReadKey();");
                result += 0;
                ResetColor();
            }
            Console.ReadKey();
            Clear();
            return result;
        }
        public int Fill_Question5()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill in the missing keyword:");
            Console.WriteLine(@"_____ num = 74.49;");
            Console.Write("Answer: ");
            string answer = Console.ReadLine().Trim();
            string correctAnswer = "double";
            string correctAnswer2 = "float";

            if (answer.Equals(correctAnswer) || answer.Equals(correctAnswer2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" num = 74.49;");
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase) || answer.Equals(correctAnswer2, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" num = 74.49;");

                Console.WriteLine();
                Console.Write("Correct Answer: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.WriteLine(@" num = 74.49;");
                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
                ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" num = 74.49;");

                Console.WriteLine();
                Console.Write("Correct Answer:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.WriteLine(@" num = 74.49;");
                result += 0;

                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Double");
                ResetColor();
                Console.WriteLine($" is a datatype that stores numbers with decimal values like 1.5, and 54.7");
            }
            Console.ReadKey();
            Clear();
            return result;
        }
        public int Fill_Value4()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine("Input the correct value:");
                Console.WriteLine("char value = '___'");
                Console.Write("Answer: ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("char value = ");
                ForegroundColor = ConsoleColor.Green;
                Console.Write($"\'{answer}\'");
                ResetColor();
                Console.Write(";");
                result += 1;
                Console.ReadKey();
                Clear();
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Your answer is not a character value.");
                ForegroundColor = ConsoleColor.Blue;
                Console.Write("Character ");
                ResetColor();
                Console.WriteLine("is a datatype that stores a singular value. Ex: A, B, 1, 2");
                result += 0;
                Console.ReadKey();
                Clear();
                return result;
            }
        }
        public int Given14()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int x = 4;\r\nint y = x++ * --x;\r\nConsole.WriteLine(y);");
                int correctAnswer;
                int x = 4;
                int y = x++ * --x;
                correctAnswer = y;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }
        public int Given15()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int a = 3;\r\nint b = a-- + ++a * a++;\r\nConsole.WriteLine(b);");
                int correctAnswer;
                int a = 3;
                int b = a-- + ++a * a++;
                correctAnswer = b;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }

        public void Arrangement()
        {
            Multiple_Choices4();
            Multiple_Choices7();
            Multiple_Choices5();
            Multiple_Choices9();
            Multiple_Choices6();
            
            Fill_Question1();
            Fill_Question5();
            Fill_Value4();
            Given14();
            Given15();

        }
        public double Result()
        {
            double grade = Evaluation.Percentage(10, result);
            Clear();
            return grade;
        }
    }
    internal class Q2_Act1
    {
        private int result = 0;
        public void Ascii_Act(int spacingAbove, int spacingBetween, int spacingBelow)
        {
            string[] numBuilder = new string[6];
            string[] ascii_act1 =
            {
            " █████╗  ██████╗████████╗██╗██╗   ██╗██╗████████╗██╗   ██╗     ██╗",
            "██╔══██╗██╔════╝╚══██╔══╝██║██║   ██║██║╚══██╔══╝╚██╗ ██╔╝    ███║",
            "███████║██║        ██║   ██║██║   ██║██║   ██║    ╚████╔╝     ╚██║",
            "██╔══██║██║        ██║   ██║╚██╗ ██╔╝██║   ██║     ╚██╔╝       ██║",
            "██║  ██║╚██████╗   ██║   ██║ ╚████╔╝ ██║   ██║      ██║        ██║",
            "╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝        ╚═╝"
            };
            string[] ascii_click =
            {
            @"                                   _                _                          _   _                  ",
            @"                                  | |              | |                        | | (_)                 ",
            @" _ __  _ __ ___  ___ ___    __ _  | | _____ _   _  | |_ ___     ___ ___  _ __ | |_ _ _ __  _   _  ___ ",
            @"| '_ \| '__/ _ \/ __/ __|  / _` | | |/ / _ \ | | | | __/ _ \   / __/ _ \| '_ \| __| | '_ \| | | |/ _ \",
            @"| |_) | | |  __/\__ \__ \ | (_| | |   <  __/ |_| | | || (_) | | (_| (_) | | | | |_| | | | | |_| |  __/",
            @"| .__/|_|  \___||___/___/  \__,_| |_|\_\___|\__, |  \__\___/   \___\___/|_| |_|\__|_|_| |_|\__,_|\___|",
            @"| |                                          __/ |                                                    ",
            @"|_|                                         |___/                                                     "
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < ascii_act1.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_act1[i].Length / 2)) + "}", ascii_act1[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < ascii_click.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_click[j].Length / 2)) + "}", ascii_click[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ReadKey();
        }

        public int Fill_Question2()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill the missing keyword:");
            Console.WriteLine(@"
int num = 0;
do
{
    Console.Write(num);
    num++;
}______(num < 5);
");
            Console.Write("Answer: ");
            string ans = Console.ReadLine();
            string answer = ans.Trim();
            string correctAnswer = "while";

            Console.WriteLine();
            if (answer.Equals(correctAnswer))
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write("(num < 5);" + "\n");
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine("(num < 5);" + "\n");
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(num < 5);");
                Console.WriteLine("\n");
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
            }
            else
            {
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine("(num < 5);" + "\n");
                Console.Write("int num = 0;" + "\n" + "do" + "\n" + "{" + "\n" + "    Console.Write(num);" + "\n" + "    num++;" + "\n" + "}");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(num < 5);");
                Console.WriteLine("\n");
                result += 0;
            }
            Console.ReadKey();
            ResetColor();
            return result;
        }
        public int Fill_Question6()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill in the missing keyword:");
            Console.WriteLine(@"_____ value = true;");
            Console.Write("Answer: ");
            string answer = Console.ReadLine().Trim();
            string correctAnswer = "bool";

            if (answer.Equals(correctAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" value = true;");
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" value = true;");

                Console.WriteLine();
                Console.WriteLine("Correct Answer: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.WriteLine(@" value = true;");
                Console.WriteLine($"Tip: C# is a case-sensitive language. Certain letters are required to be capital or small");
                result += 0;
                ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.WriteLine(@" value = true;");

                Console.WriteLine();
                Console.WriteLine("Correct Answer:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.WriteLine(@" value = true;");
                result += 0;

                Console.WriteLine();
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Boolean");
                ResetColor();
                Console.WriteLine($" is a datatype that can only take the values true or false.");
            }
            Console.ReadKey();
            Clear();
            return result;
        }
        public int Fill_Value3()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                Console.WriteLine("Input the correct value:");
                Console.WriteLine(@"double value = _______ ;");
                Console.Write("Answer: ");
                double answer = double.Parse(Console.ReadLine());
                Console.Write("double value = ");
                ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write(";");
                result += 1;
                Console.ReadKey();
                Clear();
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Your answer is not a Double value.");
                ForegroundColor = ConsoleColor.Blue;
                Console.Write("Double ");
                ResetColor();
                Console.WriteLine("is a datatype that stores numbers with decimal values like 1.5, and 54.7");
                result += 0;
                Console.ReadKey();
                Clear();
                return result;
            }
        }
        public int Given12()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int a = 5;\r\nint b = 2;\r\nConsole.WriteLine(a++ + --b - a-- + b++);");
                int correctAnswer;
                int a = 5;
                int b = 2;
                correctAnswer = a++ + --b - a-- + b++;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }
            Console.ReadKey();
            Clear();
            return result;

        }
        public int Given3()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int x = 3;\r\nint y = 2;\r\nConsole.WriteLine(y *= x + y++);");
                int x = 3;
                int y = 2;
                int correctAnswer = y *= x + y++;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }

        public void Arrangement()
        {
            Fill_Question2();
            Fill_Question6();
            Fill_Value3();
            Given12();
            Given3();
        }
        public double Result()
        {
            double grade = Evaluation.Percentage(5, result);
            Clear();
            return grade;
        }
    }
    internal class Q2_Act2
    {
        private int result = 0;
        public void Ascii_Act(int spacingAbove, int spacingBetween, int spacingBelow)
        {
            string[] numBuilder = new string[6];
            string[] ascii_act =
            {
            " █████╗  ██████╗████████╗██╗██╗   ██╗██╗████████╗██╗   ██╗    ██████╗ ",
            "██╔══██╗██╔════╝╚══██╔══╝██║██║   ██║██║╚══██╔══╝╚██╗ ██╔╝    ╚════██╗",
            "███████║██║        ██║   ██║██║   ██║██║   ██║    ╚████╔╝      █████╔╝",
            "██╔══██║██║        ██║   ██║╚██╗ ██╔╝██║   ██║     ╚██╔╝      ██╔═══╝ ",
            "██║  ██║╚██████╗   ██║   ██║ ╚████╔╝ ██║   ██║      ██║       ███████╗",
            "╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚═╝  ╚═══╝  ╚═╝   ╚═╝      ╚═╝       ╚══════╝"
            };
            string[] ascii_click =
            {
            @"                                   _                _                          _   _                  ",
            @"                                  | |              | |                        | | (_)                 ",
            @" _ __  _ __ ___  ___ ___    __ _  | | _____ _   _  | |_ ___     ___ ___  _ __ | |_ _ _ __  _   _  ___ ",
            @"| '_ \| '__/ _ \/ __/ __|  / _` | | |/ / _ \ | | | | __/ _ \   / __/ _ \| '_ \| __| | '_ \| | | |/ _ \",
            @"| |_) | | |  __/\__ \__ \ | (_| | |   <  __/ |_| | | || (_) | | (_| (_) | | | | |_| | | | | |_| |  __/",
            @"| .__/|_|  \___||___/___/  \__,_| |_|\_\___|\__, |  \__\___/   \___\___/|_| |_|\__|_|_| |_|\__,_|\___|",
            @"| |                                          __/ |                                                    ",
            @"|_|                                         |___/                                                     "
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < spacingAbove; i++) { Console.WriteLine(); }
            for (int i = 0; i < ascii_act.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_act[i].Length / 2)) + "}", ascii_act[i])); }
            for (int i = 0; i < spacingBetween; i++) { Console.WriteLine(); }
            for (int j = 0; j < ascii_click.Length; j++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ascii_click[j].Length / 2)) + "}", ascii_click[j])); };
            for (int i = 0; i < spacingBelow; i++) { Console.WriteLine(); }
            Console.ReadKey();
        }

        public int Fill_Question7()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill the missing keyword:");
            Console.WriteLine(@"
____(int i = 0 ; i < 5 ;++){
    Console.WriteLine(i);
}
");
            Console.Write("Answer: ");
            string answer = Console.ReadLine().Trim();
            string correctAnswer = "for";
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
            if (answer.Equals(correctAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write("(int i = 0 ; i < 5 ;++){ \n" + "    Console.WriteLine(i);\n" + "}");
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write("(int i = 0 ; i < 5 ;++){ \n" + "    Console.WriteLine(i);\n" + "}");
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(int i = 0 ; i < 5 ;++){ \n" + "    Console.WriteLine(i);\n" + "}");
                Console.WriteLine("\n");
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write("(int i = 0 ; i < 5 ;++){ \n" + "    Console.WriteLine(i)\n;" + "}");
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write("(int i = 0 ; i < 5 ;++){ \n" + "    Console.WriteLine(i);\n" + "}");
                Console.WriteLine();
                result += 0;
            }
            Console.ReadKey();
            ResetColor();
            Clear();
            return result;
        }
        public int Fill_Question8()
        {
            Clear();
            List<double> evaluatedGrade = new List<double>();
            double EvalGrade = Evaluation.Grade(evaluatedGrade);
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            Console.WriteLine("Fill the missing keyword:");
            string given = (@"
____:
int i = 0;
if (i < 5){
    Console.WriteLine(i);
    i++;
    goto Loop;
}
else{
    return;
}
");
            string given2 = (@":
int i = 0;
if (i < 5){
    Console.WriteLine(i);
    i++;
    goto Loop;
}
else{
    return;
}");
            Console.Write(given);
            Console.Write("Answer: ");
            string answer = Console.ReadLine().Trim();
            string correctAnswer = "Loop";
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
            if (answer.Equals(correctAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                ResetColor();
                Console.Write(given2);
                result += 1;
            }
            else if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write(given2);
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write(given2);
                Console.WriteLine("\n");
                Console.Write("Tip: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"C# is a case-sensitive language. Certain letters are required to be capital or small");
                ResetColor();
                result += 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(answer);
                ResetColor();
                Console.Write(given2);
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(correctAnswer);
                ResetColor();
                Console.Write(given2);
                Console.WriteLine();
                result += 0;
            }
            Console.ReadKey();
            ResetColor();
            Clear();
            return result;
        }
        public int Given5()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int a = 5, b = 4, c = 3;\r\nConsole.WriteLine(a++ + --b * c);");
                int a = 5, b = 4, c = 3;
                int correctAnswer = a++ + --b * c;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }
        public int Given11()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int x = 2;\r\nint y = 3;\r\nConsole.WriteLine(++x * y--);");
                int correctAnswer;
                int x = 2;
                int y = 3;
                correctAnswer = ++x * y--;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }
        public int Given7()
        {
            try
            {
                Clear();
                List<double> evaluatedGrade = new List<double>();
                double EvalGrade = Evaluation.Grade(evaluatedGrade);
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                string given = ($"int a = 5;\r\nint b = 10;\r\na = b == 10 ? a++ : --a;\r\nConsole.WriteLine(a);");
                int correctAnswer;
                int a = 5;
                int b = 10;
                a = b == 10 ? a++ : --a;
                correctAnswer = a;

                Console.WriteLine("Enter the Output of the ff code:\n");
                Console.WriteLine(given);
                Console.WriteLine();
                Console.Write("Answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == correctAnswer)
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answer);
                    ResetColor();
                    result += 1;
                }
                else
                {
                    Clear();
                    evaluatedGrade = new List<double>();
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    EvalGrade = Evaluation.Grade(evaluatedGrade);
                    Header.display(EvalGrade);
                    Console.WriteLine("Enter the Output of the ff code:\n");
                    Console.WriteLine(given);
                    Console.WriteLine();
                    Console.Write("Answer: ");
                    ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(answer);
                    ResetColor();
                    Console.WriteLine();
                    Console.Write("Correct Answer: ");
                    ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(correctAnswer);
                    ResetColor();
                    result += 0;
                }
            }
            catch (Exception)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid Input.");
                ResetColor();
                result += 0;
            }

            Console.ReadKey();
            Clear();
            return result;
        }

        public void Arrangement()
        {
            Fill_Question7();
            Fill_Question8();
            Given5();
            Given11();
            Given7();
        }
        public double Result()
        {
            double grade = Evaluation.Percentage(5, result);
            Clear();
            return grade;
        }
    }
}
