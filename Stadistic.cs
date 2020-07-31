using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Stadistic
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public double Average { get; set; }

        public Stadistic()
        {

        }

        public Stadistic(int max, int min, double average)
        {
            Max = max;
            Min = min;
            Average = average;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Stadistic other = (Stadistic)obj;

            return (other.Max == Max) &&
                (other.Min == Min) &&
                (other.Average == Average);
        }
    }
}
