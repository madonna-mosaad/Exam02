using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
    internal abstract class Question
    {
        protected string header ;
        protected Answer[] answerList;
        public string Header { 
            get 
            {
                return header ;
            } 
        }
        public Answer[] AnswerList 
        { 
            get 
            { 
                return answerList ; 
            } 
        }
        public string Body { get; set; }
        public int Mark { get; set; }
        public abstract void CreateQuestion();

    }
}
