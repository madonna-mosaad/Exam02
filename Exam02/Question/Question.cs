using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Question
{
    internal abstract class Question
    {
        #region attributes
        protected string header;
        protected Answer[] answerList;
        #endregion
        #region properties
        public string Header
        {
            get
            {
                return header;
            }
        }
        public Answer[] AnswerList
        {
            get
            {
                return answerList;
            }
        }
        public string Body { get; set; }
        public int Mark { get; set; }
        #endregion
        #region abstract method
        public abstract void CreateQuestion(); 
        #endregion

    }
}
