using System;

namespace Fragesport
{
    class Question
    {
        private String question;
        private String a;
        private String b; 
        private String c;
        private String d;
        private String answer;

        public Question(String pq, String pa, String pb, String pc, String pd, String pAnswer)
        {
          question = pq;
          a = pa;
          b = pb;
          c = pc;
          d = pd;
          answer = pAnswer;
          
        }
    }

    
}