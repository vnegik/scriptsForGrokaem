using System;
using System.Collections.Generic;
using System.Linq;

namespace GlavaFour
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(RecursiveSum(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(RecursiveCount(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(RecursiveMax(new[] { 1, 3, 2, 5, 9, 8 }));

            var arr = new[] { 10, 5, 2, 3 };
            Console.WriteLine(string.Join(", ", QuickSort(arr)));
        }

        private static int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var x in arr)
            {
                total += x;
            }
            return total;
        }

        private static int RecursiveSum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return list.Take(1).First() + RecursiveSum(list.Skip(1));
        }

        private static int RecursiveCount(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return 1 + RecursiveCount(list.Skip(1));
        }

        private static int RecursiveMax(IEnumerable<int> list)
        {
            if (!list.Any()) throw new ArgumentException(nameof(list));
            if (list.Count() == 1) return list.First();
            if (list.Count() == 2) return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();
            var sub_max = RecursiveMax(list.Skip(1));
            return list.First() > sub_max ? list.First() : sub_max;
        }

        private static IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return QuickSort(less).Union(new List<int> { pivot }).Union(QuickSort(greater));
        }
    }
}
