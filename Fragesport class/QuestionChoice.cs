﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fragesport
{
    class QuestionChoice : QuestionCard
    {
        private List<String> altList;
        private int altNum = 1;
        public QuestionChoice(String pQuestion, List<String> pAlt, String pAnswer)

        {
            question = pQuestion;
            altList = pAlt;
            answer = pAnswer;
        }
        public override void PrintQuestion() 
        {
            Console.WriteLine(question);
            Console.WriteLine("");
            foreach (var alt in altList) 
            {
                Console.WriteLine(altNum + " - " + alt);
                altNum++;
            }
            Console.WriteLine("");
            Console.WriteLine("Type the corresponding to the answer and press the ENTER key");
        }
    }
}
