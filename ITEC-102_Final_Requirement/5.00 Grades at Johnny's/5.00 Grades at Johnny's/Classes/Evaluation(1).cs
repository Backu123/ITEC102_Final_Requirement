using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Game_1.Classes
{
    public static class Evaluation
    {
        public static double Percentage(int totalNum, int totalCorrect)
        {
            double denominator = totalNum;
            double numerator = totalCorrect;
            double percentage = ((numerator / denominator) * 50) + 50;
            percentage = Math.Round(percentage, 2);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Result Percentage: {0}", percentage);
            Console.WriteLine("---------------------------------------------");
            return percentage;
        }
        public static double Grade(List<double> scores)
        {
            double grade = 1;
            try
            {
                double percentage = 0;
                foreach (double score in scores)
                {
                    percentage += score;
                }
                percentage = percentage / scores.Count;
                double gradeMax = 100;
                double gradeMin = 99;
                int gradeCounter = 0;

                for (int i = 0; i < 11; i++)
                {
                    if (i == 1) { gradeMax -= 1.01; gradeMin -= 3; }
                    if (i > 1 && i < 9) { gradeMax -= 3; gradeMin -= 3; }
                    if (i == 9) { gradeMax -= 3; gradeMin -= 5; }
                    if (i == 10) { gradeMax -= 5; gradeMin -= 70; }

                    if (percentage >= gradeMin && percentage <= gradeMax)
                    {
                        gradeCounter = i;
                    }
                }
                for (int j = 0; j < gradeCounter; j++)
                {
                    if (j <= 7) grade += 0.25;
                    if (j >= 8) grade += 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            if (scores.Count < 1) { return 5.00; }
            return grade;
        }
    }
}



              /*  if (scores.Count >= 1) Console.WriteLine("Current Equivalent Percentage: {0}\nCurrent Grade: {1}", percentage, grade);
                else Console.WriteLine("Current Equivalent Percentage: Invalid\nCurrent Grade: Invalid");*/
            /*catch (DivideByZeroException)
            {
                Console.WriteLine("Current Equivalent Percentage: Invalid\nCurrent Grade: Invalid");
            }*/
                //Console.WriteLine("Current Equivalent Percentage: Invalid\nCurrent Grade: Invalid");