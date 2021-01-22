using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        private int time;
        private string name;
        private int distance;

        public Result(string name, string time, string distance) 
        {
            try
            {
                this.name = name;
                this.time = Convert.ToInt32(time);
                this.distance = Convert.ToInt32(distance);
            }
            catch (Exception)
            {
            }
        }

        public override string ToString()
        {
            return name + " Distance: " + distance + "m " + " Time:" + time/60 + ":" + time%60;
        }
    }
}
