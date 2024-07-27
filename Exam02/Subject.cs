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
        private int id;
        private string name;
        private Exam exam;
        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }
        public void CreateExam()
        {
            int totalGrade = 0;
            int grade=0;
            Dictionary<int , string[]> dic = new Dictionary<int , string[]>();
            
            int Type;
            do
            {
                Console.WriteLine("please enter the type of exam (1 for practical | 2 for final) : ");
            } while ((!int.TryParse(Console.ReadLine(), out Type)) || (Type != 1 && Type !=2));
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
            } while (!int.TryParse(Console.ReadLine(), out T) || (T<30 || T>180));
            exam.Time = T;
            int N;
            do
            {
                Console.WriteLine("please enter the number of questions : ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            exam.NumberOfQuestion = N;
            Console.Clear();
            exam.ShowExam(ref dic,ref grade,ref totalGrade);
            
            
        }
    }
}
