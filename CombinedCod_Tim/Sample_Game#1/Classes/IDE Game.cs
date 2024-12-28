using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

    namespace Sample_Game_1.Classes
{
    public class IDE_Game
    {
        public static void Start()
        {
            Console.CursorVisible = true;
            bool loop = true;
            List<double> evaluatedList = new List<double>();
            do
            {
                loop = true;
                string looping = "";

                Console.Clear();
                errorGuide();
                Evaluation.Grade(evaluatedList);
                evaluatedList.Add(RandomProblem());
                //Console.ReadKey();


                while (looping != "y" && looping != "n")
                {
                    Console.Write("Do you want to try again?[y/n]: ");
                    looping = Console.ReadLine().ToLower();
                    if (looping == "n")
                        loop = false;

                }
            } while (loop == true);
            Console.WriteLine("Exiting...");
            Thread.Sleep(500);
        }
        public static void errorGuide()
        {
            Console.WriteLine("C# 1# Debugging Prototype []");
            Console.WriteLine("Follow Correct Spacing & Input the Correct Syntax!");
            Console.WriteLine("Debug The following Code:");
            Console.WriteLine("---------------------------------------------");
        }
        public static double RandomProblem()
        {
            int totalNumber = 0;
            int totalCorrect = 0;

            Random random = new Random();
            int probNum = 4;
            int randomNum = random.Next(0, probNum);

            switch (randomNum)
            {
                case 0: (totalNumber, totalCorrect) = BugProblem.gameProb1(); break;
                case 1: (totalNumber, totalCorrect) = BugProblem.gameProb2(); break;
                case 2: (totalNumber, totalCorrect) = BugProblem.gameProb3(); break;
                case 3: (totalNumber, totalCorrect) = BugProblem.gameProb4(); break;
                default: break;
            }

            double score = Evaluation.Percentage(totalNumber, totalCorrect);
            return score;
        }
    }
    public class BugProblem
    {
        public static (int, int) gameProb1()
        {
            const int lineCount = 13;
            int[][] correctSyntax = new int[lineCount][]
            {new int[] { 115, 116, 97, 116, 105, 99, 32, 118, 111, 105, 100, 32, 77, 97, 105, 110, 40, 41, },
            new int[] { 123, },
            new int[] { 105, 110, 116, 32, 105, 61, 48, 59, },
            new int[] { 119, 104, 105, 108, 101, 40, 105, 60, 49, 48, 48, 41, },
            new int[] { 123, },
            new int[] { 105, 43, 43, 59, },
            new int[] { 105, 102, 40, 105, 37, 50, 61, 61, 48, 38, 38, 105, 33, 61, 56, 56, 41, },
            new int[] { 123, },
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 105, 41, 59, },
            new int[] { 125, },
            new int[] { 125, },
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 82, 101, 97, 100, 75, 101, 121, 40, 41, 59, },
            new int[] { 125, }};

            Console.WriteLine(" 1|  static void Main()");
            Console.WriteLine(" 2|  {");
            Console.WriteLine(" 3|  \tint i = 0");
            Console.WriteLine(" 4|  \twhile i < 100");
            Console.WriteLine(" 5|  \t{");
            Console.WriteLine(" 6|  \t\ti++");
            Console.WriteLine(" 7|  \tif i % 2 = 0 & i != 88");
            Console.WriteLine(" 8|  \t\t{");
            Console.WriteLine(" 9|  \t\t\tConsole.Writeline(\"i\");");
            Console.WriteLine("10|  \t\t}");
            Console.WriteLine("11|  \t}");
            Console.WriteLine("12|  \tConsole.ReadKey;");
            Console.WriteLine("13|  }");
            Console.WriteLine("---------------------------------------------");

            /* string[] CorrectGiven1 =
               {"static void Main()", //1
                 "{", //2
                 "int i = 0;", //3
                 "while i ( < 100)", //4
                 "{", //5
                 "i++;", //6
                 "if (i % 2 = 0 && i != 88)", //7
                 "{", //8
                 "Console.Writeline(i);", //9
                 "}", //10
                 "}", //11
                 "Console.ReadKey;", //12
                 "}", //13
             };*/

            int correctCount;
            int wrongCount;
            Debugger Prob1 = new Debugger(correctSyntax);
            (correctCount, wrongCount) = Prob1.Solution();

            return (lineCount, correctCount);
        }
        public static (int, int) gameProb2()
        {
            const int lineCount = 7;
            int[][] correctSyntax = new int[lineCount][]
            {new int[] {105, 110, 116, 32, 105, 61, 48, 59,},
            new int[] { 119, 104, 105, 108, 101, 40, 105, 60, 49, 48, 41, },
            new int[] { 123, },
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 34, 72, 101, 108, 108, 111, 87, 111, 114, 108, 100, 33, 34, 41, 59,},
            new int[] { 105, 43, 43, 59, },
            new int[] { 125,},
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 82, 101, 97, 100, 75, 101, 121, 40, 41, 59, }};

            Console.WriteLine(" 1|  int i = 0;");
            Console.WriteLine(" 2|  while (i > 10)");
            Console.WriteLine(" 3|  }");
            Console.WriteLine(" 4|  \tConsole.writeline(Hello World!);");
            Console.WriteLine(" 5|  \ti+;");
            Console.WriteLine(" 6|  }");
            Console.WriteLine(" 7|  Console.ReadKey;");
            Console.WriteLine("---------------------------------------------");

            /*Console.WriteLine("int i = 0;");
            Console.WriteLine("while (i < 10)");
            Console.WriteLine("{");
            Console.WriteLine("    Console.WriteLine(\"Hello World!\");");
            Console.WriteLine("    i++;");
            Console.WriteLine("}");
            Console.WriteLine("Console.ReadKey();");
            Console.WriteLine("---------------------------------------------");*/

            int correctCount;
            int wrongCount;
            Debugger Prob1 = new Debugger(correctSyntax);
            (correctCount, wrongCount) = Prob1.Solution();

            return (lineCount, correctCount);
        }
        public static (int, int) gameProb3()
        {
            const int lineCount = 5;
            int[][] correctSyntax = new int[lineCount][]
                {new int[] {105, 110, 116, 91, 93, 110, 117, 109, 61, 123, 49, 44, 50, 44, 51, 44, 52, 44, 53, 125, 59,},
                new int[] { 102, 111, 114, 40, 105, 110, 116, 32, 105, 61, 48, 59, 105, 60, 110, 117, 109, 46, 76, 101, 110, 103, 116, 104, 59, 105, 43, 43, 41,},
                new int[] { 123, },
                new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 110, 117, 109, 91, 105, 93, 41, 59,},
                new int[] { 125, } };

            Console.WriteLine(" 1|  int() num ={ 1, 2, 3, 4, 5}");
            Console.WriteLine(" 2|  for ( int i = 0; i > num.Length; i+)");
            Console.WriteLine(" 3|  }");
            Console.WriteLine(" 4|  \tConsole.WriteLine(num['i'])");
            Console.WriteLine(" 5|  }");
            Console.WriteLine("---------------------------------------------");

            int correctCount;
            int wrongCount;
            Debugger Prob1 = new Debugger(correctSyntax);
            (correctCount, wrongCount) = Prob1.Solution();

            return (lineCount, correctCount);
        }
        public static (int, int) gameProb4()
        {
            const int lineCount = 8;
            int[][] correctSyntax = new int[lineCount][]
            {new int[] {102, 111, 114, 40, 105, 110, 116, 32, 105, 61, 49, 59, 105, 60, 61, 51, 59, 105, 43, 43, 41,},
            new int[] { 123},
            new int[] { 102, 111, 114, 40, 105, 110, 116, 32, 106, 61, 49, 59, 106, 60, 61, 105, 59, 106, 43, 43, 41,},
            new int[] { 123},
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 106, 41, 59,},
            new int[] { 125},
            new int[] { 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 41, 59, },
            new int[] { 125, }};

            Console.WriteLine(" 1|  for (int i = 1; i >= 3; i++);");
            Console.WriteLine(" 2|  }");
            Console.WriteLine(" 3|  \tfor (int j = 1; j <= i j++);");
            Console.WriteLine(" 4|  \t{");
            Console.WriteLine(" 5|  \t\tConsole.Write('j')");
            Console.WriteLine(" 6|  \t{");
            Console.WriteLine(" 7|  \tConsole.WriteLine()");
            Console.WriteLine(" 8|  }");
            Console.WriteLine("---------------------------------------------");

            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j * 0);
                }
                Console.Write('\n');
            }*/

            int correctCount;
            int wrongCount;
            Debugger Prob1 = new Debugger(correctSyntax);
            (correctCount, wrongCount) = Prob1.Solution();

            return (lineCount, correctCount);
        }
    }
    class Debugger
    {
        int lineCount;
        int[][] correctAnswer;
        public Debugger(int[][] problem)
        {
            this.lineCount = problem.GetLength(0);
            this.correctAnswer = problem;
        }

        public (int, int) Solution()
        {


            int correctCount = 0;
            int wrongCount = 0;

            List<int> errorLines = new List<int>();
            List<List<int>> asciiContainer = new List<List<int>>();

            string[] linesSyntax = new string[lineCount];

            for (int lines = 0; lines < lineCount; lines++)
            {
                Console.Write(lines < 9 ? $" {lines + 1}|  " : $"{lines + 1}|  ");
                linesSyntax[lines] = SyntaxMaker.inputReader(linesSyntax, lines);
            }

            List<int> container = new List<int>();
            for (int listCounter = 0; listCounter < lineCount; listCounter++)
            {
                asciiContainer.Add(SyntaxMaker.asciiConverter(linesSyntax, listCounter));
            }

            for (int LineNum = 0; LineNum < lineCount; LineNum++)
            {
                int outCorrect, outWrong, wrongLine;
                (outCorrect, outWrong, wrongLine) = SyntaxMaker.compareArrayToList(correctAnswer, asciiContainer, LineNum);
                if (wrongLine != 0) { errorLines.Add(wrongLine); }
                correctCount += outCorrect;
                wrongCount += outWrong;
            }

            //line debugger :D
            /* Console.WriteLine("---------------------------------------------");
             Console.WriteLine("Int[][] Given");
             int checkLine = 0;
             foreach (int nums in correctAnswer[checkLine])
             {
                 Console.Write($"{nums}, ");
             }
             Console.WriteLine();
             Console.WriteLine("lIST");
             foreach (int sublist2 in asciiContainer[checkLine])
             {
                 Console.Write($"{sublist2}, ");
             }
             Console.WriteLine();*/

            //SyntaxMaker.resultCounter(correctCount, wrongCount, lineCount);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{wrongCount} Errors.");
            int zeroCount = 0;
            foreach (int zeros in errorLines) { if (zeros == 0) { ++zeroCount; } }
            if (errorLines.Count() == zeroCount) { Console.WriteLine("No issues found. \nAll of your answers are correct!!"); }
            else if (errorLines.Count() - 1 == zeroCount) { Console.WriteLine($"You have an error at the line {errorLines[0]}"); }
            else
            {
                bool firstError = true;
                Console.Write("You have an error at lines(");
                for (int error = 0; error < errorLines.Count; error++)
                {
                    if (firstError == true)
                    {
                        if (errorLines[error] != 0 && firstError == true) { Console.Write($"{errorLines[error]}"); firstError = false; }

                    }
                    else
                    {
                        if (errorLines[error] != 0) { Console.Write(", {0}", errorLines[error]); }

                    }
                }
                Console.WriteLine(")");
            }
            return (correctCount, wrongCount);
        }
    }
    public class SyntaxMaker
    {
        public static string inputReader(string[] arrayString, int arrayOrder)
        {

            string input = Console.ReadLine();

            if (input.Length == 0)
            {
                while (input.Length == 0)
                {
                    Console.Write(arrayOrder < 9 ? $" {arrayOrder + 1}|  " : $"{arrayOrder + 1}|  ");
                    input = Console.ReadLine();
                    arrayString[arrayOrder] = input;
                }
            }
            //end:
            return input;
            //aayusin ko pa to chineck dapat nito yung kapag spaces at tabs lang ang nilagay dun sa input di sya mareread
            /*or (int characterCount = 0; characterCount == input.Length; characterCount++)
            {
                int i = Convert.ToInt32(input[characterCount]);
                charNum.Add(i);
            }
            while (charChecker != charNum.Count())
            {
                if (charNum[charChecker] == 32 || charNum[charChecker] == 9)
                {

                }
                else
                {
                    goto end;
                }
                ++charChecker;
            }
            charNum.Clear();*/
        }
        public static List<int> asciiConverter(string[] syntax, int counter)
        {
            List<int> list = new List<int>();
            char character = 'a';
            int signCounter = 0;
            int syn1 = syntax[counter].Length;

            while (signCounter != syn1)
            {
                character = Convert.ToChar(syntax[counter][signCounter]);

                //Operators CHECKER
                if (VariableChecker.OPERATORS(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //static CHECKER
                else if (VariableChecker.STATIC(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //void CHECKER
                else if (VariableChecker.VOID(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //Main CHECKER
                else if (VariableChecker.MAIN(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //int CHECKER
                else if (VariableChecker.INT(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //double CHECKER
                else if (VariableChecker.DOUBLE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //string CHECKER
                else if (VariableChecker.STRING(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //char CHECKER
                else if (VariableChecker.CHAR(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //bool CHECKER
                else if (VariableChecker.BOOL(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //const CHECKER
                else if (VariableChecker.CONST(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //=======================================================================================================================//
                //loops
                //While
                else if (VariableChecker.DO(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.WHILE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.FOR(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.FOREACH(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //decision
                else if (VariableChecker.ELSEIF(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.IF(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.ELSE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //switch
                else if (VariableChecker.SWITCH(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.BREAK(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.CONTINUE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.DEFAULT(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                else if (VariableChecker.CASE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }

                //=======================================================================================================================//
                //Functions
                //WriteLine
                else if (VariableChecker.WRITELINE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //Write
                else if (VariableChecker.WRITE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //Readline
                else if (VariableChecker.READLINE(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //Read
                else if (VariableChecker.READ(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }
                //ReadKey
                else if (VariableChecker.READKEY(syntax, counter, character, signCounter) == true) { list.Add(Convert.ToInt32(character)); }

                //SPACE REMOVER
                else if (character != 32 && character != 9) { list.Add(Convert.ToInt32(character)); }

                signCounter++;
            }
            return list;
        }
        public static (int, int, int) compareArrayToList(int[][] givenASCII, List<List<int>> userInput, int num)
        {
            int wrong = 0;
            int correct = 0;
            int errorLine = 0;
            int arrayCounter = 0;
            int correctCounter = 0;
            int arrayCount = givenASCII[num].Count();
            int listCount = userInput[num].Count();

            while (arrayCounter < listCount && arrayCounter < arrayCount)
            {
                try
                {
                    if (givenASCII[num][arrayCounter] == userInput[num][arrayCounter])
                    {
                        ++correctCounter;
                    }
                }
                catch
                {

                }

                ++arrayCounter;
            }

            while (arrayCounter != listCount)
            {
                ++arrayCounter;
            }

            if (correctCounter == arrayCounter && correctCounter == arrayCount && correctCounter != 0 && arrayCounter != 0)
            {
                //Console.WriteLine($"Your Syntax & Capitalization is correct in Line {num + 1}");
                correct++;
            }
            else
            {//: CorrectCounter:{correctCounter}, arrayCounter:{arrayCounter}, arrayCount:{arrayCount}
                //Console.WriteLine($"You have a Syntax/Capitalization error In Line {num + 1}");
                errorLine = num + 1;
                wrong++;
            }
            return (correct, wrong, errorLine);
        }
        public static void resultCounter(int correctCount, int wrongCount, int lineCount)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Correct: {correctCount}");
            Console.WriteLine($"Wrong: {wrongCount}");
            Console.WriteLine($"Total Lines: {lineCount}");
        }

    }
    public class VariableChecker
    {
        //only checks space in between the word
        public static bool OPERATORS(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                if (//Relational Operators
                   signCounter > 0 && syntax[counter][signCounter - 1] == 33 && character == 32 && syntax[counter][signCounter + 1] == 61 || //!=
                   signCounter > 0 && syntax[counter][signCounter - 1] == 61 && character == 32 && syntax[counter][signCounter + 1] == 61 || //==
                   signCounter > 0 && syntax[counter][signCounter - 1] == 60 && character == 32 && syntax[counter][signCounter + 1] == 61 || //<=
                   signCounter > 0 && syntax[counter][signCounter - 1] == 62 && character == 32 && syntax[counter][signCounter + 1] == 61 || //>=
                                                                                                                                             //Assignment Operators
                   signCounter > 0 && syntax[counter][signCounter - 1] == 43 && character == 32 && syntax[counter][signCounter + 1] == 61 || //+=
                   signCounter > 0 && syntax[counter][signCounter - 1] == 45 && character == 32 && syntax[counter][signCounter + 1] == 61 || //-=
                   signCounter > 0 && syntax[counter][signCounter - 1] == 47 && character == 32 && syntax[counter][signCounter + 1] == 61 || ///=
                   signCounter > 0 && syntax[counter][signCounter - 1] == 42 && character == 32 && syntax[counter][signCounter + 1] == 61 || //*=
                                                                                                                                             //Increment Decrement
                   signCounter > 0 && syntax[counter][signCounter - 1] == 43 && character == 32 && syntax[counter][signCounter + 1] == 43 || //++
                   signCounter > 0 && syntax[counter][signCounter - 1] == 45 && character == 32 && syntax[counter][signCounter + 1] == 45 || //--
                                                                                                                                             //Logical Operators
                                                                                                                                             //signCounter > 0 && syntax[counter][signCounter - 1] == 33 && character == 32 && syntax[counter][signCounter + 1] == 40 || //!(
                   signCounter > 0 && syntax[counter][signCounter - 1] == 38 && character == 32 && syntax[counter][signCounter + 1] == 38 || //&&
                   signCounter > 0 && syntax[counter][signCounter - 1] == 124 && character == 32 && syntax[counter][signCounter + 1] == 124//||               
                   )
                {
                    checker = true;
                }
            }
            catch { }
            return checker;
        }
        public static bool MAIN(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -3;
                int b = -2;
                int c = -1;
                int d = 1;
                for (int z = 2; z >= 0; z--)
                { //77, 97, 105, 110, [Main]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 77 && syntax[counter][signCounter + b] == 97 && syntax[counter][signCounter + c] == 105 && syntax[counter][signCounter + d] == 110)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) { a++; }
                    b++; if (b == 0) { b++; }
                    c++; if (c == 0) { c++; }
                    d++; if (d == 0) { d++; }
                }
            }
            catch { }
            return checker;
        }
        public static bool DO(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -1;
                int b = 1;

                for (int z = 0; z >= 0; z--)
                { //100, 111, [do]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 100 && syntax[counter][signCounter + b] == 111)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                }
            }
            catch { }
            return checker;
        }
        public static bool WHILE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;
                int e = 1;

                for (int z = 3; z >= 0; z--)
                { //119, 104, 105, 108, 101, [while]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 119 && syntax[counter][signCounter + b] == 104 && syntax[counter][signCounter + c] == 105 && syntax[counter][signCounter + d] == 108 && syntax[counter][signCounter + e] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                }
            }
            catch { }
            return checker;
        }
        public static bool FOR(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -2;
                int b = -1;
                int c = 1;

                for (int z = 1; z >= 0; z--)
                { //102, 111, 114, [for]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 102 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 114)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                }
            }
            catch { }
            return checker;
        }
        public static bool FOREACH(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -6;
                int b = -5;
                int c = -4;
                int d = -3;
                int e = -2;
                int f = -1;
                int g = 1;

                for (int z = 5; z >= 0; z--)
                { //102, 111, 114, 101, 97, 99, 104, [foreach]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 102 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 114 && syntax[counter][signCounter + d] == 101 && syntax[counter][signCounter + e] == 97 && syntax[counter][signCounter + f] == 99 && syntax[counter][signCounter + g] == 104)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                }
            }
            catch { }
            return checker;
        }
        public static bool ELSEIF(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -5;
                int b = -4;
                int c = -3;
                int d = -2;
                int e = -1;
                int f = 1;

                for (int z = 0; z >= 0; z--)
                { //69, 76, 83, 69, 73, 70, [ELSEIF]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 69 && syntax[counter][signCounter + b] == 76 && syntax[counter][signCounter + c] == 83 && syntax[counter][signCounter + d] == 69 && syntax[counter][signCounter + e] == 73 && syntax[counter][signCounter + f] == 70)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                }
            }
            catch { }
            return checker;
        }
        public static bool IF(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -1;
                int b = 1;

                for (int z = 0; z >= 0; z--)
                { //105, 102, [if]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 105 && syntax[counter][signCounter + b] == 102)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                }
            }
            catch { }
            return checker;
        }
        public static bool ELSE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -3;
                int b = -2;
                int c = -1;
                int d = 1;

                for (int z = 2; z >= 0; z--)
                { //101, 108, 115, 101, [else]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 101 && syntax[counter][signCounter + b] == 108 && syntax[counter][signCounter + c] == 115 && syntax[counter][signCounter + d] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                }
            }
            catch { }
            return checker;
        }
        public static bool SWITCH(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -5;
                int b = -4;
                int c = -3;
                int d = -2;
                int e = -1;
                int f = 1;

                for (int z = 4; z >= 0; z--)
                { //115, 119, 105, 116, 99, 104, [switch]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 115 && syntax[counter][signCounter + b] == 119 && syntax[counter][signCounter + c] == 105 && syntax[counter][signCounter + d] == 116 && syntax[counter][signCounter + e] == 99 && syntax[counter][signCounter + f] == 104)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                }
            }
            catch { }
            return checker;
        }
        public static bool BREAK(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;
                int e = 1;

                for (int z = 3; z >= 0; z--)
                { //98, 114, 101, 97, 107, [break]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 98 && syntax[counter][signCounter + b] == 114 && syntax[counter][signCounter + c] == 101 && syntax[counter][signCounter + d] == 97 && syntax[counter][signCounter + e] == 107)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                }
            }
            catch { }
            return checker;
        }
        public static bool DEFAULT(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -6;
                int b = -5;
                int c = -4;
                int d = -3;
                int e = -2;
                int f = -1;
                int g = 1;

                for (int z = 5; z >= 0; z--)
                { //100, 101, 102, 97, 117, 108, 116, [default]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 100 && syntax[counter][signCounter + b] == 101 && syntax[counter][signCounter + c] == 102 && syntax[counter][signCounter + d] == 97 && syntax[counter][signCounter + e] == 117 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 116)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                }
            }
            catch { }
            return checker;
        }
        public static bool CONTINUE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -7;
                int b = -6;
                int c = -5;
                int d = -4;
                int e = -3;
                int f = -2;
                int g = -1;
                int h = 1;

                for (int z = 6; z >= 0; z--)
                { //99, 111, 110, 116, 105, 110, 117, 101, [continue]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 99 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 116 && syntax[counter][signCounter + e] == 105 && syntax[counter][signCounter + f] == 110 && syntax[counter][signCounter + g] == 117 && syntax[counter][signCounter + h] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                }
            }
            catch { }
            return checker;
        }
        //functions
        public static bool WRITELINE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -16;
                int b = -15;
                int c = -14;
                int d = -13;
                int e = -12;
                int f = -11;
                int g = -10;
                int h = -9;
                int i = -8;
                int j = -7;
                int k = -6;
                int l = -5;
                int m = -4;
                int n = -3;
                int o = -2;
                int p = -1;
                int q = 1;
                for (int z = 15; z >= 0; z--)
                { //67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, [Console.WriteLine]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 67 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 111 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 101 && syntax[counter][signCounter + h] == 46 && syntax[counter][signCounter + i] == 87 && syntax[counter][signCounter + j] == 114 && syntax[counter][signCounter + k] == 105 && syntax[counter][signCounter + l] == 116 && syntax[counter][signCounter + m] == 101 && syntax[counter][signCounter + n] == 76 && syntax[counter][signCounter + o] == 105 && syntax[counter][signCounter + p] == 110 && syntax[counter][signCounter + q] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                    i++; if (i == 0) i++;
                    j++; if (j == 0) j++;
                    k++; if (k == 0) k++;
                    l++; if (l == 0) l++;
                    m++; if (m == 0) m++;
                    n++; if (n == 0) n++;
                    o++; if (o == 0) o++;
                    p++; if (p == 0) p++;
                    q++; if (q == 0) q++;
                }
            }
            catch { }
            return checker;
        }
        public static bool WRITE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -12;
                int b = -11;
                int c = -10;
                int d = -9;
                int e = -8;
                int f = -7;
                int g = -6;
                int h = -5;
                int i = -4;
                int j = -3;
                int k = -2;
                int l = -1;
                int m = 1;
                for (int z = 11; z >= 0; z--)
                { //67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, [Console.Write]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 67 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 111 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 101 && syntax[counter][signCounter + h] == 46 && syntax[counter][signCounter + i] == 87 && syntax[counter][signCounter + j] == 114 && syntax[counter][signCounter + k] == 105 && syntax[counter][signCounter + l] == 116 && syntax[counter][signCounter + m] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                    i++; if (i == 0) i++;
                    j++; if (j == 0) j++;
                    k++; if (k == 0) k++;
                    l++; if (l == 0) l++;
                    m++; if (m == 0) m++;
                }
            }
            catch { }
            return checker;
        }
        public static bool READLINE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -15;
                int b = -14;
                int c = -13;
                int d = -12;
                int e = -11;
                int f = -10;
                int g = -9;
                int h = -8;
                int i = -7;
                int j = -6;
                int k = -5;
                int l = -4;
                int m = -3;
                int n = -2;
                int o = -1;
                int p = 1;

                for (int z = 14; z >= 0; z--)
                { //67, 111, 110, 115, 111, 108, 101, 46, 82, 101, 97, 100, 76, 105, 110, 101, [Console.ReadLine]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 67 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 111 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 101 && syntax[counter][signCounter + h] == 46 && syntax[counter][signCounter + i] == 82 && syntax[counter][signCounter + j] == 101 && syntax[counter][signCounter + k] == 97 && syntax[counter][signCounter + l] == 100 && syntax[counter][signCounter + m] == 76 && syntax[counter][signCounter + n] == 105 && syntax[counter][signCounter + o] == 110 && syntax[counter][signCounter + p] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                    i++; if (i == 0) i++;
                    j++; if (j == 0) j++;
                    k++; if (k == 0) k++;
                    l++; if (l == 0) l++;
                    m++; if (m == 0) m++;
                    n++; if (n == 0) n++;
                    o++; if (o == 0) o++;
                    p++; if (p == 0) p++;
                }
            }
            catch { }
            return checker;
        }
        public static bool READ(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -11;
                int b = -10;
                int c = -9;
                int d = -8;
                int e = -7;
                int f = -6;
                int g = -5;
                int h = -4;
                int i = -3;
                int j = -2;
                int k = -1;
                int l = 1;

                for (int z = 10; z >= 0; z--)
                { //67, 111, 110, 115, 111, 108, 101, 46, 82, 101, 97, 100, [Console.Read]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 67 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 111 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 101 && syntax[counter][signCounter + h] == 46 && syntax[counter][signCounter + i] == 82 && syntax[counter][signCounter + j] == 101 && syntax[counter][signCounter + k] == 97 && syntax[counter][signCounter + l] == 100)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                    i++; if (i == 0) i++;
                    j++; if (j == 0) j++;
                    k++; if (k == 0) k++;
                    l++; if (l == 0) l++;
                }
            }
            catch { }
            return checker;
        }
        public static bool READKEY(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -14;
                int b = -13;
                int c = -12;
                int d = -11;
                int e = -10;
                int f = -9;
                int g = -8;
                int h = -7;
                int i = -6;
                int j = -5;
                int k = -4;
                int l = -3;
                int m = -2;
                int n = -1;
                int o = 1;

                for (int z = 13; z >= 0; z--)
                { //67, 111, 110, 115, 111, 108, 101, 46, 82, 101, 97, 100, 75, 101, 121, [Console.ReadKey]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 67 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 111 && syntax[counter][signCounter + f] == 108 && syntax[counter][signCounter + g] == 101 && syntax[counter][signCounter + h] == 46 && syntax[counter][signCounter + i] == 82 && syntax[counter][signCounter + j] == 101 && syntax[counter][signCounter + k] == 97 && syntax[counter][signCounter + l] == 100 && syntax[counter][signCounter + m] == 75 && syntax[counter][signCounter + n] == 101 && syntax[counter][signCounter + o] == 121)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                    g++; if (g == 0) g++;
                    h++; if (h == 0) h++;
                    i++; if (i == 0) i++;
                    j++; if (j == 0) j++;
                    k++; if (k == 0) k++;
                    l++; if (l == 0) l++;
                    m++; if (m == 0) m++;
                    n++; if (n == 0) n++;
                    o++; if (o == 0) o++;
                }
            }
            catch { }
            return checker;
        }
        //checks space in between and after the word
        public static bool CASE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;

                for (int z = 3; z >= 0; z--)
                { //
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 99 && syntax[counter][signCounter + b] == 97 && syntax[counter][signCounter + c] == 115 && syntax[counter][signCounter + d] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                }
            }
            catch { }
            return checker;
        }
        public static bool STATIC(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -6;
                int b = -5;
                int c = -4;
                int d = -3;
                int e = -2;
                int f = -1;
                for (int z = 5; z >= 0; z--)
                { //115, 116, 97, 116, 105, 99 [static]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 115 && syntax[counter][signCounter + b] == 116 && syntax[counter][signCounter + c] == 97 && syntax[counter][signCounter + d] == 116 && syntax[counter][signCounter + e] == 105 && syntax[counter][signCounter + f] == 99)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) { a++; }
                    b++; if (b == 0) { b++; }
                    c++; if (c == 0) { c++; }
                    d++; if (d == 0) { d++; }
                    e++; if (e == 0) { e++; }
                    f++; if (f == 0) { f++; }
                }
            }
            catch { }
            return checker;
        }
        public static bool VOID(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;
                for (int z = 3; z >= 0; z--)
                { //118, 111, 105, 100, [void]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 118 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 105 && syntax[counter][signCounter + d] == 100)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) { a++; }
                    b++; if (b == 0) { b++; }
                    c++; if (c == 0) { c++; }
                    d++; if (d == 0) { d++; }
                }
            }
            catch { }
            return checker;
        }
        public static bool INT(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -3;
                int b = -2;
                int c = -1;
                int d = 1;
                int e = 2;
                for (int z = 2; z >= 0; z--)
                {//105, 110, 116 [int]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 105 && syntax[counter][signCounter + b] == 110 && syntax[counter][signCounter + c] == 116)
                    {
                        checker = true;
                    }
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 105 && syntax[counter][signCounter + b] == 110 && syntax[counter][signCounter + c] == 116 && syntax[counter][signCounter + d] == 91 && syntax[counter][signCounter + e] == 93)
                    {//array checker 91, 93, []
                        checker = false;
                    }
                    a++; if (a == 0) { a++; }
                    b++; if (b == 0) { b++; }
                    c++; if (c == 0) { c++; }
                    d++; if (d == 0) { d++; }
                    e++; if (e == 0) { e++; }
                }
            }
            catch { }
            return checker;
        }
        public static bool DOUBLE(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -6;
                int b = -5;
                int c = -4;
                int d = -3;
                int e = -2;
                int f = -1;
                for (int z = 5; z >= 0; z--)
                {//105, 110, 116 [int]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 100 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 117 && syntax[counter][signCounter + d] == 98 && syntax[counter][signCounter + e] == 108 && syntax[counter][signCounter + f] == 101)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                    f++; if (f == 0) f++;
                }
            }
            catch { }
            return checker;
        }
        public static bool STRING(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -6;
                int b = -5;
                int c = -4;
                int d = -3;
                int e = -2;
                int f = -1;
                for (int z = 5; z >= 0; z--)
                { //115, 116, 114, 105, 110, 103, [string]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 115 && syntax[counter][signCounter + b] == 116 && syntax[counter][signCounter + c] == 114 && syntax[counter][signCounter + d] == 105 && syntax[counter][signCounter + e] == 110 && syntax[counter][signCounter + f] == 103)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) { a++; }
                    b++; if (b == 0) { b++; }
                    c++; if (c == 0) { c++; }
                    d++; if (d == 0) { d++; }
                    e++; if (e == 0) { e++; }
                    f++; if (f == 0) { f++; }
                }
            }
            catch { }
            return checker;
        }
        public static bool CHAR(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;

                for (int z = 3; z >= 0; z--)
                { //99, 104, 97, 114, [char]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 99 && syntax[counter][signCounter + b] == 104 && syntax[counter][signCounter + c] == 97 && syntax[counter][signCounter + d] == 114)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                }
            }
            catch { }
            return checker;
        }
        public static bool BOOL(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -4;
                int b = -3;
                int c = -2;
                int d = -1;

                for (int z = 3; z >= 0; z--)
                { //98, 111, 111, 108, [bool]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 98 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 111 && syntax[counter][signCounter + d] == 108)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                }
            }
            catch { }
            return checker;
        }
        public static bool CONST(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -5;
                int b = -4;
                int c = -3;
                int d = -2;
                int e = -1;

                for (int z = 4; z >= 0; z--)
                { //99, 111, 110, 115, 116, [const]
                    if (signCounter > z && character == 32 && syntax[counter][signCounter + a] == 99 && syntax[counter][signCounter + b] == 111 && syntax[counter][signCounter + c] == 110 && syntax[counter][signCounter + d] == 115 && syntax[counter][signCounter + e] == 116)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                    b++; if (b == 0) b++;
                    c++; if (c == 0) c++;
                    d++; if (d == 0) d++;
                    e++; if (e == 0) e++;
                }
            }
            catch { }
            return checker;
        }
        //copy
        public static bool copy(string[] syntax, int counter, char character, int signCounter)
        {
            bool checker = false;
            try
            {
                int a = -12;

                for (int z = 0; z >= 0; z--)
                { //
                    if (signCounter > z && character == 32)
                    {
                        checker = true;
                    }
                    a++; if (a == 0) a++;
                }
            }
            catch { }
            return checker;
        }
    }
}
   
