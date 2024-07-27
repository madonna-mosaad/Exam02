using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
    internal class T_F : Question
    {
        public T_F() 
        {
            header = "True or False question";
        }

        public override void CreateQuestion()
        {
            Console.WriteLine(header);
            Console.WriteLine("please enter the Question body : ");
            Body = Console.ReadLine();
            int M;
            do
            {
                Console.WriteLine("please enter the question mark : ");
            } while (!int.TryParse(Console.ReadLine(), out M));
            Mark = M;
            
            int id;
            do
            {
                Console.WriteLine("please enter the right answer id (1 for true | 2 for false):");
            } while (!int.TryParse(Console.ReadLine(), out id) || (id !=1 && id !=2));
            Answer a = new Answer()
            {
                Id = id
            };
            answerList = new Answer[]
            {
                new Answer() {Id =1 , Text ="true" },
                new Answer() {Id =2 , Text ="false"},
                a
            };
            
        }
    }
}
