using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal abstract class Exam
    {
        public int Time{ get; set; }
        public int NumberOfQuestion {  get; set; }
        public abstract void ShowExam(ref Dictionary<int , string[]> d , ref int g, ref int tg);
    }
}
