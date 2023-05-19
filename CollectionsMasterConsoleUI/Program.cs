using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new int[50] ;

            Populater(myArray);

            Console.WriteLine($"The first number of the array is {myArray[0]}");
            Console.WriteLine($"The last number of the array is {myArray[49]}");
            Console.WriteLine("All Numbers Original");

            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");

            Console.WriteLine("************Start Lists**************");

            var myList = new List<int>();

            Console.WriteLine($"The capacity of the new list is {myList.Count}");

            Populater(myList);

            Console.WriteLine($"The capacity is now {myList.Count}");

            Console.WriteLine("---------------------");

            Console.WriteLine("What number will you search for in the number list?");
            int.TryParse(Console.ReadLine(), out int num);
            NumberChecker(myList, num);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(myList);
            Console.WriteLine("-------------------");

            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            int[] newArray = myList.ToArray();

            myList.Clear();
            Console.WriteLine("List cleared and count is:");
            Console.WriteLine(myList.Count);
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < 50; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber) == true)
            {
                Console.WriteLine($"{searchNumber} is on the list.");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not on the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
                {
                    numbers[i] = rng.Next(0, 50);
                }
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
