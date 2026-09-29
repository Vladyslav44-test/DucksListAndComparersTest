using System;
using System.Collections.Generic;
using System.Text;

namespace DucksListAndComparersTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 }
            };
            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            Console.WriteLine("\nSorting by size then kind\n");
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
            IComparer<Duck> kindComparer = new DuckComparerByKind();
            Console.WriteLine("\nSorting by kind then size\n");
            ducks.Sort(kindComparer);
            PrintDucks(ducks);
            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            Console.WriteLine("\nSorting by kind then size\n");
            ducks.Sort(comparer);
            PrintDucks(ducks);
            comparer.SortBy = SortCriteria.SizeThenKind;
            Console.WriteLine("\nSorting by size then kind\n");
            ducks.Sort(comparer);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
    }
}
