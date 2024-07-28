using Exam02.Question;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal class Final : Exam
    {
        public override void ShowExam(ref Dictionary<int, string[]> dic , ref int grade , ref int totalGrade)
        {
            MCQ mcq;
            T_F tf;
            for (int i = 0; i < NumberOfQuestion; i++)
            {

                int Q;
                do
                {
                    Console.WriteLine("please enter the type of question (1 for MCQ | 2 for True|False) : ");
                } while ((!int.TryParse(Console.ReadLine(), out Q)) || (Q != 1 && Q != 2));
                Console.Clear();
                if (Q == 1)
                {
                    mcq = new MCQ();
                    mcq.CreateQuestion();
                    totalGrade += mcq.Mark;
                    //0:header ,1:body , 2:mark ,3:id1 text ,4:id2 text , 5:id3 text ,6:right id text
                    dic[i] = new string[]
                    {
                        mcq.Header,
                        mcq.Body,
                        Convert.ToString(mcq.Mark),
                        mcq.AnswerList[0].Text,
                        mcq.AnswerList[1].Text,
                        mcq.AnswerList[2].Text,
                        mcq.AnswerList[mcq.AnswerList[3].Id-1].Text
                    };
                }
                else if (Q == 2)
                {
                    tf = new T_F();
                    tf.CreateQuestion();
                    totalGrade += tf.Mark;
                    //0:header ,1:body , 2:mark ,3:id1 text ,4:id2 text , 5:right id text
                    dic[i] = new string[]
                    {
                        tf.Header,
                        tf.Body,
                        Convert.ToString(tf.Mark),
                        tf.AnswerList[0].Text,
                        tf.AnswerList[1].Text,
                        tf.AnswerList[tf.AnswerList[2].Id-1].Text
                    };
                }
                Console.Clear();
            }
            Y_N ans;
            do
            {
                Console.WriteLine("Do you want to start the exam (Y|N)");

            } while (!Enum.TryParse(Console.ReadLine(), true, out ans));
            Console.Clear();
            if ((ans & ((Y_N)1)) == ((Y_N)1))
            {
                Console.Clear();
                for (int i = 0; i < NumberOfQuestion; i++)
                {
                    
                    stopwatch.Start();
                    if (stopwatch.Elapsed >= Time)
                    {

                        message = "time out";
                        break;
                    }

                    if (dic[i][0] == "MCQ question")
                    {
                        Console.WriteLine($"{dic[i][0]}   Mark{dic[i][2]}");
                        Console.WriteLine();
                        Console.WriteLine(dic[i][1]);
                        Console.WriteLine();
                        Console.WriteLine($"1-{dic[i][3]}");
                        Console.WriteLine($"2-{dic[i][4]}");
                        Console.WriteLine($"3-{dic[i][5]}");

                        int RA;
                        do
                        {
                            Console.WriteLine("please enter the answer id :");
                        } while (!int.TryParse(Console.ReadLine(), out RA) || (RA != 1 && RA != 2 && RA != 3));

                        if (dic[i][RA+2] == dic[i][6])
                        {
                            bool flag = int.TryParse(dic[i][2], out int x);
                            grade += x;
                        }
                        ResDic[i] = new string[] { dic[i][1], dic[i][6], dic[i][RA + 2] };
                    }
                    else if (dic[i][0] == "True or False question")
                    {
                        Console.WriteLine($"{dic[i][0]}   Mark{dic[i][2]}");
                        Console.WriteLine();
                        Console.WriteLine(dic[i][1]);
                        Console.WriteLine();
                        Console.WriteLine($"1-{dic[i][3]}");
                        Console.WriteLine($"2-{dic[i][4]}");


                        int RA;
                        do
                        {
                            Console.WriteLine("please enter the answer id :");
                        } while (!int.TryParse(Console.ReadLine(), out RA) || (RA != 1 && RA != 2));

                        if (dic[i][RA+2] == dic[i][5])
                        {
                            bool flag = int.TryParse(dic[i][2], out int x);
                            grade += x;
                        }
                        ResDic[i] = new string[] { dic[i][1], dic[i][5], dic[i][RA + 2] };
                    }
                    
                }

            }
            Console.Clear();
            stopwatch.Stop();
            ShowResult( ResDic, grade, totalGrade,stopwatch);

        }
        
    }
}
