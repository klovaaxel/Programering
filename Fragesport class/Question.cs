using System;

namespace Fragesport
{
    class QuestionCard
    {
        private String question;
        public String Question 
        {
          get
          {
            return question;
          }
        }
        public String a {get;}
        public String b {get;}
        public String c {get;}
        public String d {get;}
        public String answer {get;}

        public QuestionCard(String pQuestion, String pa, String pb, String pc, String pd, String pAnswer)
        {
          question = pQuestion;
          a = pa;
          b = pb;
          c = pc;
          d = pd;
          answer = pAnswer;
          
        }
    }

    
}