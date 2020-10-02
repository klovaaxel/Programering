﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fragesport
{
    class QuestionText : QuestionCard
    {

        public QuestionText(String Q, String A) 
        {
            question = Q;
            answer = A;
        }

        public override void PrintQuestion()
        {
            Console.WriteLine(question);
            Console.WriteLine("");
            Console.WriteLine("Type the answer and then press the ENTER key to continue");
        }
    }
}