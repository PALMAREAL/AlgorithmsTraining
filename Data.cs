using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpTraining
{
    public class Data
    {
        public Data()
        {

        }
        
        public Data(int[] values)
        {
            Values = values;
            // init value x
            // inti value y
            //.....
        }

        public int[] Values { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Data other = (Data)obj;

            if (!other.Values.Any()) return false;

            if (Values.Length != other.Values.Length) return false;

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] != other.Values[i]) return false;
            }

            return true;
        }

    }
}
