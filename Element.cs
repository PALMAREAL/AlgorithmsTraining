using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public class Element
    {
        public int Max { get; set; }

        public char MaxChar { get; set; }

        public Element(int max, char maxChar)
        {
            Max = max;
            MaxChar = maxChar;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Element other = (Element)obj;

            return (Max == other.Max) && (MaxChar == other.MaxChar);
        }
    }
}
