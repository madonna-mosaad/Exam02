using Exam02.Exams;
using Exam02.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam02
{
    internal class Subject
    {
        #region attributes
        private int id;
        private string name;
        private Exam exam;
        #endregion
        #region constructor
        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        #endregion
        #region methods
        public void CreateExam()
        {

            int Type;
            do
            {
                Console.WriteLine("please enter the type of exam (1 for practical | 2 for final) : ");
            } while ((!int.TryParse(Console.ReadLine(), out Type)) || (Type != 1 && Type != 2));
            if (Type == 2)
            {
                exam = new Final();
            }
            else if (Type == 1)
            {
                exam = new Practical();
            }
            int T;
            do
            {
                Console.WriteLine("please enter the time of exam (30 min to 180 min) : ");
            } while (!int.TryParse(Console.ReadLine(), out T) || (T < 30 || T > 180));
            exam.Time = TimeSpan.FromMinutes(T);
            int N;
            do
            {
                Console.WriteLine("please enter the number of questions : ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            exam.NumberOfQuestion = N;
            Console.Clear();
            exam.ShowExam();


        } 
        #endregion
    }
}
