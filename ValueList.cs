using System.Collections.Generic;
using System.Linq;

namespace CsharpTraining
{
    public class ValueList
    {
        public List<int> PositiveList { get; set; }

        public List<int> NegativeList { get; set; }

        public ValueList()
        {
            NegativeList = new List<int>();
            PositiveList = new List<int>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            ValueList other = (ValueList)obj;

            return AreEquals(PositiveList, other.PositiveList) &&
                AreEquals(NegativeList, other.NegativeList);
        }

        private bool AreEquals(List<int> list1, List<int> list2)
        {
            return list1.SequenceEqual(list2);
        }
    }
}