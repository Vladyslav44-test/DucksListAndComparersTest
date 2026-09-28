using System;
using System.Collections.Generic;
using System.Text;

namespace DucksListAndComparersTest
{
    internal class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size) return 1;
            else if (this.Size < duckToCompare.Size) return -1;
            return 0;
        }
    }
}
