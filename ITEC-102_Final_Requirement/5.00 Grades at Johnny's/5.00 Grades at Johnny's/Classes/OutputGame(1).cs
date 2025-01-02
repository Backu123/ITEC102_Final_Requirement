using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class OutputGame
    {
        public static (int, int) Start(int probCount)
        {
            int count = 0;
            int result = 0;
            Console.Write("----------------------------------------------------\n");
            Console.WriteLine("Please Answer The Following Problems: ");
            do
            {

                Random rand = new Random();
                List<int> listProb = new List<int>();
                int givenNum = 16;
                for (int i = 0; i <= givenNum; i++) { listProb.Add(i); }
                int arrayRand = rand.Next(0, givenNum);

                while (listProb[arrayRand] == 100)
                {
                    arrayRand = rand.Next(0, givenNum);
                }
                Console.Write("----------------------------------------------------\n");
                Console.WriteLine("Please Answer The Following Problems: ");
                string answer = randomizer(arrayRand);
                Console.Write("-------------------------\n");
                Console.Write("Input Correct Output: ");
                string input = Console.ReadLine();
                if (answer == input)
                {
                    Console.WriteLine("Your answer is correct!");
                    ++result;
                }
                else
                {
                    Console.WriteLine("\"Your answer is wrong.");
                    Console.WriteLine($"The correct asnwer is {answer}.");
                }
                listProb[arrayRand] = 100;
                count++;
            } while (count <= probCount);

            Console.ReadKey();
            return (probCount, result);
        }

        static string randomizer(int arrayRand)
        {
            string ans = "";
            switch (arrayRand)
            {
                case 0: ans = Syntax.Given1(); break;
                case 1: ans = Syntax.Given2(); break;
                case 2: ans = Syntax.Given3(); break;
                case 3: ans = Syntax.Given4(); break;
                case 4: ans = Syntax.Given5(); break;
                case 5: ans = Syntax.Given6(); break;
                case 6: ans = Syntax.Given7(); break;
                case 7: ans = Syntax.Given8(); break;
                case 8: ans = Syntax.Given9(); break;
                case 9: ans = Syntax.Given10(); break;
                case 10: ans = Syntax.Given11(); break;
                case 11: ans = Syntax.Given12(); break;
                case 12: ans = Syntax.Given13(); break;
                case 13: ans = Syntax.Given14(); break;
                case 14: ans = Syntax.Given15(); break;
                case 15: ans = Syntax.Given16(); break;
                default: break;
            }
            return ans;
        }
    }
    //Given Problems
    public class Syntax
    {
        public static string Given1()
        {
            string given1 = "int a = 5;\r\nint b = 3;\r\nif ((a = 7) == b)\r\n    Console.WriteLine(a + b);\r\nelse\r\n    Console.WriteLine(a - b);";
            Console.WriteLine($"{given1}");

            int a = 5;
            int b = 3;
            int right = 0;
            if ((a = 7) == b)
                right = a + b;
            else
                right = a - b;

            string answer = Convert.ToString(right);
            return answer;


        }
        public static string Given2()
        {

            Console.WriteLine($"int x = 1;\r\nConsole.WriteLine(x++ + ++x);");
            int x = 1;
            int right = x++ + ++x;

            string answer = Convert.ToString(right);
            return answer;
        }

        public static string Given3()
        {
            Console.WriteLine($"int x = 3;\r\nint y = 2;\r\nConsole.WriteLine(y *= x + y++);");
            int x = 3;
            int y = 2;
            int right = y *= x + y++;

            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given4()
        {
            Console.WriteLine($"int x = 10;\r\nint y = -x;\r\nConsole.WriteLine(x < 0 ? -x : y);");
            int right;

            int x = 10;
            int y = -x;
            right = x < 0 ? -x : y;

            string answer = Convert.ToString(right);
            return answer;
        }

        public static string Given5()
        {
            Console.WriteLine($"int a = 5, b = 4, c = 3;\r\nConsole.WriteLine(a++ + --b * c);");
            int a = 5, b = 4, c = 3;
            int right = a++ + --b * c;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given6()
        {
            Console.WriteLine($"int a = 0;\r\nConsole.WriteLine(a++ == 0 ? \"Equal\" : \"Not Equal\");\r\nConsole.WriteLine(a);");
            int a = 0;
            string right = (a++ == 0) ? "Equal" : "Not Equal";


            string answer = Convert.ToString(right);
            return answer;
        }

        public static string Given7()
        {
            Console.WriteLine($"int a = 5;\r\nint b = 10;\r\na = b == 10 ? a++ : --a;\r\nConsole.WriteLine(a);");

            //string right = 
            int right;

            int a = 5;
            int b = 10;
            a = b == 10 ? a++ : --a;
            right = a;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given8()
        {
            Console.WriteLine($"int a = 3;\r\nConsole.WriteLine(a++ * 2 == 6 ? \"Yes\" : \"No\");");

            string right = "";
            //int right = 7;
            int a = 3;
            right = a++ * 2 == 6 ? "Yes" : "No";
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given9()
        {
            Console.WriteLine($"int x = 5;\r\nConsole.WriteLine(x++ + x++ + x);");

            //string right = 
            int right;
            int x = 5;
            right = x++ + x++ + x;

            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given10()
        {
            Console.WriteLine($"");

            //string right = "";
            int right;
            int a = 1;
            right = (a-- * a) + ++a;

            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given11()
        {
            Console.WriteLine($"int x = 2;\r\nint y = 3;\r\nConsole.WriteLine(++x * y--);");

            //string right = "";
            int right;
            int x = 2;
            int y = 3;
            right = ++x * y--;
            string answer = Convert.ToString(right);
            return answer;
        }

        public static string Given12()
        {
            Console.WriteLine($"int a = 5;\r\nint b = 2;\r\nConsole.WriteLine(a++ + --b - a-- + b++);");

            //string right = "";
            int right;
            int a = 5;
            int b = 2;
            right = a++ + --b - a-- + b++;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given13()
        {
            Console.WriteLine($"int a = 7;\r\na += (a -= 3) + (a *= 2);\r\nConsole.WriteLine(a);");

            //string right = "";
            int right;
            int a = 7;
            a += (a -= 3) + (a *= 2);
            right = a;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given14()
        {
            Console.WriteLine($"int x = 4;\r\nint y = x++ * --x;\r\nConsole.WriteLine(y);");

            //string right = "";
            int right;
            int x = 4;
            int y = x++ * --x;
            right = y;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given15()
        {
            Console.WriteLine($"int a = 3;\r\nint b = a-- + ++a * a++;\r\nConsole.WriteLine(b);");

            //string right = "";
            int right;
            int a = 3;
            int b = a-- + ++a * a++;
            right = b;
            string answer = Convert.ToString(right);
            return answer;
        }
        public static string Given16()
        {
            Console.WriteLine($"int a = 2;\r\nConsole.WriteLine(++a + a-- * ++a);");

            //string right = "";
            int right;
            int a = 2;
            right = ++a + a-- * ++a;
            string answer = Convert.ToString(right);
            return answer;
        }

        /* public static string Given()
         {
             Console.WriteLine($"");

             //string right = "";
             int right;
             int a = 7;
             int b = 7;
             (if a == 1)
                 (if a == 2)
                 Console.WriteLine(a + b);
             Else
                Console.WriteLine(a - b);
             Console.WriteLine(a + b +”\b”);
             Console.WriteLine(a + b);
             Console.ReadKey();

             string answer = Convert.ToString(right);
             return answer;
         }*/

        /* 

         public static string Given()
         {
             Console.WriteLine($"");

             //string right = "";
             int right;

             string answer = Convert.ToString(right);
             return answer;
         }

        */
    }
}
