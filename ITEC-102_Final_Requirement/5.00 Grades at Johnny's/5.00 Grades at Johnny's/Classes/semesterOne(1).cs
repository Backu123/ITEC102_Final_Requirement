using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public class semesterOne
    {
        public static void start()
        {
            List<double> evaluatedGrade = new List<double>();
            List<double> actTotal = new List<double>();
            List<double> midTerms = new List<double>();

            List<double> labTotal = new List<double>();
            List<double> finalTotal = new List<double>();

            int[] debugNum = { 0, 1, 2, 3, 4, 5, };

            double EvalGrade = Evaluation.Grade(evaluatedGrade);



            // Activity 1
            Console.Clear();
            Activity_1 act1 = new Activity_1();
            act1.Ascii_Act1(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
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
            IDE_Game.laboratory(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
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


            // Activity 2
            Console.Clear();
            Activity_2 act2 = new Activity_2();
            act2.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);

            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);
            act2.Arrangement();
            double grade2 = act2.Result();
            actTotal.Add(grade2);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);


            // MidTerms
            Console.Clear();
            Midterms mid = new Midterms();
            mid.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            mid.Arrangement();
            double mGrade = mid.Result();
            midTerms.Add(mGrade);

            EvalGrade = Evaluation.Grade(midTerms);
            Header.display(EvalGrade);

            Console.ReadKey(true);


            // Q2 Act 1
            Console.Clear();
            Q2_Act1 q2Act1 = new Q2_Act1();
            q2Act1.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            q2Act1.Arrangement();
            double qGrade = q2Act1.Result();
            actTotal.Add(qGrade);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);

            // Laboratory
            Console.Clear();
            IDE_Game.laboratory(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
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
            q2Act2.Ascii_Act(spacingAbove: 5, spacingBetween: 3, spacingBelow: 3);
            Console.Clear();
            EvalGrade = Evaluation.Grade(evaluatedGrade);
            Header.display(EvalGrade);

            q2Act2.Arrangement();
            double qGrade2 = q2Act2.Result();
            actTotal.Add(qGrade2);

            EvalGrade = Evaluation.Grade(actTotal);
            Header.display(EvalGrade);

            Console.ReadKey(true);

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
