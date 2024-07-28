using Exam02.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam02.Question
{
    internal class MCQ: Question
    {
        public MCQ()
        {
            header = "MCQ question";
        }

        public override void CreateQuestion()
        {
            Console.WriteLine(header);
            Console.WriteLine("please enter the Question body : ");
            Body = Console.ReadLine() ?? "no question";
            int M;
            do
            {
                Console.WriteLine("please enter the question mark : ");
            } while (!int.TryParse(Console.ReadLine(), out M));
            Mark = M;
            Console.WriteLine("choices of question");
            Console.WriteLine("please enter choice number 1 :");
            Answer a1 = new Answer() { Id = 1, Text = Console.ReadLine() ?? "no Answer" };
            Console.WriteLine("please enter choice number 2 :");
            Answer a2 = new Answer() { Id = 2, Text = Console.ReadLine() ?? "no Answer"};
            Console.WriteLine("please enter choice number 3 :");
            Answer a3 = new Answer() { Id = 3, Text = Console.ReadLine() ?? "no Answer" };
            
            int id;
            do
            {
                Console.WriteLine("please enter the right answer id :");
            } while (!int.TryParse(Console.ReadLine(), out id) || (id != 1 && id != 2 && id !=3));
            Answer a4 = new Answer() 
            { 
                Id = id
            };
            answerList = new Answer[]
            {
                a1,a2,a3,a4
            };
            
        }
    }
}
