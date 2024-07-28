using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal abstract class Exam
    {
        protected Dictionary<int, string[]> ResDic = new Dictionary<int, string[]>();
        protected Stopwatch stopwatch = new Stopwatch();
        protected string message;
        public TimeSpan Time{ get; set; }
        public int NumberOfQuestion {  get; set; }
        public abstract void ShowExam(ref Dictionary<int , string[]> d , ref int g, ref int tg);
        public void ShowResult( Dictionary<int, string[]> Resdic,  int grade,  int totalGrade, Stopwatch stopwatch)
        {
            if (message != null)
            {
                Console.WriteLine(message);
            }
            for (int i = 0; i < ResDic.Count; i++)
            {

                Console.WriteLine($"Question {i + 1} : {ResDic[i][0]}");
                Console.WriteLine($"your answer => {ResDic[i][2]}");
                Console.WriteLine($"Right answer => {ResDic[i][1]}");
                Console.WriteLine();

            }
            Console.WriteLine($"Your grade is {grade} from {totalGrade}");
            Console.WriteLine($"Time = {stopwatch.Elapsed}");
        }

    }
}
