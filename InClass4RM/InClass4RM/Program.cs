/*
 * Name of project: InClass4RM
 * Purpose: To display the final exam score, average exam score, maximum score and its index, minimum score and its index.
 *
 * Revision Histrory:
 *      Rutvi Mistry, 2023.03.22: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass4RM
{
    internal class Program
    {
        static void Main(string[] args)
        {   int sum = 0;
            double average = 0;
            int maxScore = 0;
            int maxScoreIndex = 0;
            int minScore = 0;
            int minScoreIndex = 0;

            int[] examScore = { 88, 81, 56, 72, 93, 74, 80, 66, 71, 73 };
            //1. Display final exam score
            for (int i = 0; i < examScore.Length; i++)
            {
                Console.Write(examScore[i] + " ");
            }
            Console.WriteLine();

            //2. Display the avearage exam score
            for (int i = 0; i < examScore.Length; i++)
            {
                sum = sum + examScore[i];
            }
            average = (double)sum / examScore.Length;
            Console.Write($"\nThe average exam score: {average}\n");

            //3. Display the highest exam score and index position
            maxScore = examScore[0];
            for (int i = 0; i < examScore.Length; i++)
            {
                if (maxScore < examScore[i])
                {
                    maxScore = examScore[i];
                    maxScoreIndex = i;
                }
            }
            Console.WriteLine($"\nThe highest score :{maxScore}");
            Console.WriteLine($"Index position of max score: {maxScoreIndex}");

            //4.Display the lowest exam score and index position 
            minScore = examScore[0];
            for (int i = 0; i < examScore.Length; i++)
            {
                if (minScore > examScore[i])
                {
                    minScore = examScore[i];
                    minScoreIndex = i;
                }
            }
            Console.WriteLine($"\nThe lowest score :{minScore}");
            Console.WriteLine($"Index position of min score: {minScoreIndex}");

            Console.ReadKey();
        }
    }
}
