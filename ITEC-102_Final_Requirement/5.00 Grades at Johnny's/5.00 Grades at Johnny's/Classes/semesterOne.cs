using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using static System.Console;

namespace Sample_Game_1.Classes
{
    public class semesterOne
    {
        private static bool skip = false;
        public static void SlowPrint(string text, int delay = 40)
        {
            Thread inputThread = new Thread(() =>
            {
                while (!skip)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        skip = true;
                    }
                }
            });
            inputThread.Start();

            foreach (char c in text)
            {
                if (skip)
                {
                    delay = 0;
                }

                Console.Write(c);
                Thread.Sleep(delay);  // Adjust the delay for slower or faster text display
            }
            Console.WriteLine();
            skip = false;
            inputThread.Abort();

        }
        public static void start()
        {
            List<double> evaluatedGrade = new List<double>();
            List<double> actTotal = new List<double>();
            List<double> midTerms = new List<double>();

            List<double> labTotal = new List<double>();
            List<double> finalTotal = new List<double>();

            int[] debugNum = { 0, 1, 2, 3, 4, 5, };

            double EvalGrade = Evaluation.Grade(evaluatedGrade);


            // --- Activity 1 - The First Lab Activity ---
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 10: First Lab Activity Notification");
            SlowPrint("The first lab activity notification arrives. You open the task to see what’s in store.");
            Console.WriteLine();
            SlowPrint("Lab Activity 1 – [Type of Activity]: Due in 2 Hours.");
            SlowPrint("You read through the instructions carefully and get to work.");
            SlowPrint("However before you get started, you saw a small message from your professor.");
            SlowPrint("This is just the beginning. Don’t disappoint me.");
            Console.WriteLine();
            SlowPrint("Cold sweats started to appear on your forehead.");
            SlowPrint("I can handle this. Focus and get it done. You muttered.");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }

            // Activity 1
            Console.Clear();
            Activity_1 act1 = new Activity_1();
            Console.ForegroundColor = ConsoleColor.Green;
            act1.Ascii_Act1(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            act1.Arrangement();
            double grade = act1.Result();
            actTotal.Add(grade);
            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);
            Console.ReadKey(true);

            // Laboratory
            Console.Clear();
            ForegroundColor = ConsoleColor.Yellow;
            IDE_Game.laboratory(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            double labGrade;
            (labGrade, debugNum) = IDE_Game.Start(debugNum);
            Console.Clear();
            labTotal.Add(labGrade);
            EvalGrade = Evaluation.Grade(labTotal);
            Header.display(EvalGrade);
            Console.ReadKey(true);

            // Day 10 
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 10: First Activity - Results.");
            SlowPrint("After submitting your activity, you instantly received a notification from your professor.");
            Console.WriteLine();
            SlowPrint("Johnny: Barely adequate. You’ve completed it, but there’s plenty of room for improvement. Don’t slack off.");
            Console.WriteLine();
            SlowPrint("...");
            SlowPrint("It’s not perfect, but it’s done. I’ll do better next time. You whispered to yourself.");
            

            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }
            // Day 18
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("It was the 18th day in your HOC102 course, you saw on your screen that the second lab activity arrives, and it’s time to face another challenge.");
            Console.WriteLine();
            Console.WriteLine("Activity 1 and 1st Lab Activity – [Type of Activity]: Due in 2 Hours. ");
            SlowPrint("You review the instructions carefully and started preparing to work.");
            SlowPrint("Johnny: You’ve had practice now. Don’t waste it.");
            Console.ReadKey();

            Console.Clear();
            SlowPrint("Seeing your professor's comment, you cannot help but feel pressure from the activity.");
            Console.WriteLine();
            SlowPrint("\"Alright, let’s make this one better than the last.\"");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }


            // Activity 2
            Console.Clear();
            Activity_2 act2 = new Activity_2();
            Console.ForegroundColor = ConsoleColor.Green;
            act2.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            act2.Arrangement();
            double grade2 = act2.Result();
            actTotal.Add(grade2);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);

            //Day 18 - Results
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 18: Results");
            Console.WriteLine();
            SlowPrint("Drenched in sweat, you smiled in response as you read your professor's comment to your work");
            Console.WriteLine();
            SlowPrint("[Much better. Keep this up, and you’ll be on track.]");
            Console.WriteLine();
            SlowPrint("\"Yosh! I did better! I'm starting to get the hang of this.\"");
            
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }
            //Day 30
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 30: Midterms is appraoching.");
            Console.WriteLine();
            SlowPrint("Time quickly passed and it's just almost the day of your midterms.");
            Console.WriteLine();
            SlowPrint("The midterm is just another test. I’ve handled these lab activities. I can do this.");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }

            //Day 35
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 35: Midterms");
            Console.WriteLine();
            SlowPrint("The midterm exam notification appears.You take a deep breath as you prepare for the real challenge.");
            SlowPrint("[Midterm Exam: Begin Now.]");

            Console.WriteLine();
            SlowPrint("Reading the instructions, you sit up straighter, knowing this is the big test. You start working with determination.");

            Console.WriteLine("");
            SlowPrint("Before you start, a short messaged once again popped up on your screen.");
            Console.WriteLine("[This is where you show what you’ve learned. No excuses.]");
            SlowPrint("Focus. I can handle this. Just like the practice activities.");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }


            // MidTerms
            Console.Clear();
            Midterms mid = new Midterms();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            mid.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            mid.Arrangement();
            double mGrade = mid.Result();
            midTerms.Add(mGrade);

            EvalGrade = Evaluation.Grade(midTerms);
            Header.display(EvalGrade);

            Console.ReadKey(true);

            if (mGrade >= 4)
            {
                Console.Clear();

                Console.WriteLine();
                Jumpscare.scare();
                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {

                //Day 35 Midterms - Results
                Console.Clear();
                Header.title();
                Console.WriteLine();
                SlowPrint("Day 35: Midterms - Results");
                Console.WriteLine();
                SlowPrint("You worked for 1 hours on the midterm. When the time runs out, you submit your work and wait nervously for the results.");
                Console.WriteLine();
                SlowPrint("In an instant, your results arrived along with the message of your professor.");
                Console.WriteLine();
                SlowPrint("[Excellent. You’ve passed the midterm. This is the kind of work I expect from you.]");
                Console.WriteLine();
                SlowPrint("Seeing that you passed, your lips slowly curved into a big smile.");
                SlowPrint("\"Thank god I passed.\"");
                Console.WriteLine();
                Console.WriteLine("Press x to continue...");

                while (Console.ReadKey().Key != ConsoleKey.X)
                {
                }
            }

            //Day 50
            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 50 - Second Quarter, 1st Activity.");
            Console.WriteLine();
            SlowPrint("Days quickly passed after your midterms and it's now time for the first activity on the second quarter.");
            Console.WriteLine();
            SlowPrint("A few minutes later, the third lab activity arrives. You’re back in the groove of things, ready for another challenge.");
            Console.WriteLine();
            SlowPrint("[1st Activity – [Type of Activity]: Due in 2 Hours.]");
            SlowPrint("You dive into the task, ready to put your skills to the test.");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }


            // Q2 Act 1
            Console.Clear();
            Q2_Act1 q2Act1 = new Q2_Act1();
            Console.ForegroundColor = ConsoleColor.Yellow;
            q2Act1.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            q2Act1.Arrangement();
            double qGrade = q2Act1.Result();
            actTotal.Add(qGrade);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);

            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 60: 2nd Quarter Activity Notification");
            SlowPrint("The final lab activity of the semester arrives.");
            Console.WriteLine();
            SlowPrint("Notification Pops Up on Screen:");
            SlowPrint("[2nd Activity, 2nd Lab Activity – [Type of Activity]: Due in 2 Hours.]");

            SlowPrint("You know this one is your last chance to show your full potential before the finals.");

            SlowPrint("Johnny’s Voice: ");
            SlowPrint("\"This is your final chance. Don’t let it slip away.\"");

            SlowPrint("Inner Monologue: ");
            SlowPrint("\"I’m going to give it my all.\"");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }


            // Laboratory
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            IDE_Game.laboratory(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            (labGrade, debugNum) = IDE_Game.Start(debugNum);
            Console.Clear();
            labTotal.Add(labGrade);
            EvalGrade = Evaluation.Grade(labTotal);
            Header.display(EvalGrade);
            Console.ReadKey(true);


            // Q2 Act 2
            Console.Clear();
            Q2_Act2 q2Act2 = new Q2_Act2();
            Console.ForegroundColor = ConsoleColor.Red;
            q2Act2.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            ResetColor();
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            q2Act2.Arrangement();
            double qGrade2 = q2Act2.Result();
            actTotal.Add(qGrade2);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);

            Console.Clear();
            Header.title();
            Console.WriteLine();
            SlowPrint("Day 70: Final Exam Notification");
            SlowPrint("The final exam notification arrives. This is it—the last test of the semester.");
            Console.WriteLine();
            SlowPrint("Notification Pops Up on Screen:");
            SlowPrint("\"Final Exam – [Type of Activity]: Begin Now.\"");

            SlowPrint("You take a deep breath and get started on the final exam, knowing it’s time to show everything you’ve learned.");

            SlowPrint("Johnny’s Voice: ");
            SlowPrint("\"This is it. Your final test. Don’t blow it.\"");

            SlowPrint("Inner Monologue: ");
            SlowPrint("\"Stay calm. You’ve made it this far. Just do your best.\"");
            Console.WriteLine();
            Console.WriteLine("Press x to continue...");

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
            }

            // Laboratory
            Console.Clear();
            IDE_Game.finals(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            Console.Clear();
            double finals;
            for (int i = 0; i < 4; i++)
            {
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                (finals, debugNum) = IDE_Game.Start(debugNum);
                Console.Clear();
                finalTotal.Add(finals);
            }
            EvalGrade = Evaluation.Grade(finalTotal);
            Header.display(EvalGrade);
            Console.ReadKey(true);

            double act = 0;
            double lab = 0;
            double midGrade = 0;
            double fin = 0;
            double eval = 0;
               
            foreach (double ave in actTotal)
            {
                act += ave;
                //Console.WriteLine($"actTotal {ave}");
            }
            foreach(double ave in midTerms)
            {
                midGrade += ave;
                //Console.WriteLine($"midTerms {ave}");
            }
            foreach (double ave in labTotal)
            {
                lab += ave;
                //Console.WriteLine($"labTotal {ave}");
            }
            foreach (double ave in finalTotal)
            {
                fin += ave;
                //Console.WriteLine($"finalTotal {ave}");
            }

            act /= actTotal.Count;
            lab /= labTotal.Count;
            midGrade /= midTerms.Count;
            fin /= finalTotal.Count;

            evaluatedGrade.Add(act);
            evaluatedGrade.Add(lab);
            evaluatedGrade.Add(midGrade);
            evaluatedGrade.Add(fin);    

            foreach (double ave in evaluatedGrade)
            {
                eval += ave;
            }
            eval /= evaluatedGrade.Count;
            Console.WriteLine($"final_average = {eval}");
            Console.ReadKey();

            Console.Clear();
            string[] Graded = new string[6];
            Graded = Header.asciiLetter(eval);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 12; i++) { Console.WriteLine(); }
            for (int i = 0; i < Graded.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Graded[i].Length / 2)) + "}", Graded[i])); }

            Console.ReadKey();

            if (eval < 4)
            {
                Console.Clear();
                Header.title();
                Console.WriteLine();
                SlowPrint("Day 75: Final Results – Good Ending (First Semester)");
                Console.WriteLine();
                SlowPrint("You check your final results and feel a wave of relief when you see your passing grade.");

                SlowPrint("Johnny’s Voice: ");
                SlowPrint("\"Excellent. You’ve earned your place among the best.\"");

                SlowPrint("Inner Monologue: ");
                SlowPrint("\"I did it. I really did it. I’m ready for whatever comes next.\"");

                Console.WriteLine();
                Console.WriteLine("Press x to continue...");

                while (Console.ReadKey().Key != ConsoleKey.X)
                {
                }
            }
            else
            {
                Console.Clear();
                Header.title();
                Console.WriteLine();
                SlowPrint("Day 75: Final Results - Bad Ending (First Semster)");
                Console.WriteLine();
                Console.Clear();
                Jumpscare.scare();
                Console.WriteLine();
                return;

            }           


            /*while (true)
            {
                Console.Clear();
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                double grade = IDE_Game.Start();
                evaluatedGrade.Add(grade);

                Console.Clear();

                int probCount = 10;
                int total = 0;
                int result = 0;
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                (total, result) = OutputGame.Start(probCount);
                double OPgrade = Evaluation.Percentage(total, result);
                evaluatedGrade.Add(OPgrade);

                Console.Clear();

                probCount = 5;
                total = 0;
                result = 0;
                EvalGrade = Evaluation.Grade(evaluatedGrade);
                Header.display(EvalGrade);
                (total, result) = OutputGame.Start(probCount);
                OPgrade = Evaluation.Percentage(total, result);
                evaluatedGrade.Add(OPgrade);

                Console.ReadKey();
            }*/


            /*  QuizGame quizGame = new QuizGame();
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
                  IDE_Game.Start();*/
        }
    }
}
