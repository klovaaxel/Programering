using System;
using System.Collections.Generic;
using System.Text;

namespace Fragesport_File
{
    public class Score
    {
        private int score;
        private int maxScore;
        public void AddScore()
        {
            score++;
            maxScore++;
        }
        public void AddMaxScore()
        {
            maxScore++;
        }
        public int GetScore() 
        {
            return score;
        }
        public int GetMaxScore() 
        {
            return maxScore;
        }
    }
}
