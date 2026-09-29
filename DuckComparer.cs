using System;
using System.Collections.Generic;
using System.Text;

namespace DucksListAndComparersTest
{
    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }

    internal class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size) return 1;
                else if (x.Size < y.Size) return -1;
                else
                {
                    if (x.Kind > y.Kind) return 1;
                    else if (x.Kind < y.Kind) return -1;
                    return 0;
                }
            }
            else
            {
                if (x.Kind > y.Kind) return 1;
                else if (x.Kind < y.Kind) return -1;
                else
                {
                    if (x.Size > y.Size) return 1;
                    else if (x.Size < y.Size) return -1;
                    return 0;
                }
            }
        }
    }
}
