using System;
using System.Collections.Generic;
using System.Text;

namespace Fragesport
{
    class QuestionChoice : QuestionCard
    {

        public String a { get; }
        public String b { get; }
        public String c { get; }
        public String d { get; }
        public QuestionChoice (String pQuestion, String pa, String pb, String pc, String pd, String pAnswer)
        {
            question = pQuestion;
            a = pa;
            b = pb;
            c = pc;
            d = pd;
            answer = pAnswer;
        }
        public override void PrintQuestion() 
        {
            Console.WriteLine(question);
            Console.WriteLine("");
            Console.WriteLine("A - " + a + "  B - " + b);
            Console.WriteLine("C - " + c + "  D - " + d);
            Console.WriteLine("");
            Console.WriteLine("Type the corresponding to the answer and press the ENTER key");
        }
    }
}
