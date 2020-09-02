using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Бинарная сортировка
            #region VipolneniePervoiGlavi
            List<int> myList = new List<int> { 1, 3, 5, 7, 9 };
            Console.WriteLine(BinarySearch(myList, 3)); // => 1
            Console.WriteLine(BinarySearch(myList, -1)); // => null gets printed as an empty string
            #endregion

            // Сортировка выбором 
            #region VipolnenieVtoroiGlavi
            List<int> arr = new List<int> { 5, 3, 6, 2, 10 };
            Console.WriteLine(string.Join(", ", SelectionSort(arr)));
            #endregion
        }

        // Бинарная сортировка
        #region ALgoritmIsPervoiGlavi
        private static int? BinarySearch(IList<int> list, int item)
        {
            int low = 0;
            int high = list.Count() - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item) return mid;
                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return null;
        }
        #endregion

        // сортировка выбором
        #region ALgoritmIsVtoroiGlavi 
        private static int[] SelectionSort(List<int> arr)
        {
            var newArr = new int[arr.Count];
            for (int i = 0; i < newArr.Length; i++)
            {
                var smallest = FindSmallest(arr);
                newArr[i] = arr[smallest];
                arr.RemoveAt(smallest);
            }
            return newArr;
        }

        private static int FindSmallest(List<int> arr)
        {
            var smallest = arr[0];
            var smallestIndex = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        
        }
        #endregion

    }
}
