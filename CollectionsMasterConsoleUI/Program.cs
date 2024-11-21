using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            
            var array1 = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(array1);

            //TODO: Print the first number of the array

            Console.WriteLine(array1[0]);

            //TODO: Print the last number of the array

            Console.WriteLine(array1[array1.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(array1);
            
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(array1);
            NumberPrinter(array1);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(array1);
            NumberPrinter(array1);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(array1);
            NumberPrinter(array1);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(array1);
            NumberPrinter(array1);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            var list1 = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine(list1.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(list1);

            //TODO: Print the new capacity
            
            Console.WriteLine(list1.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            bool isNum;
            int searchnumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNum = int.TryParse(Console.ReadLine(), out searchnumber);
            } while (!isNum);

            NumberChecker(list1, searchnumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(list1);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(list1);
            NumberPrinter(list1);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            list1.Sort();
            NumberPrinter(list1);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            var listCopyToArrary = list1.ToArray();

            //TODO: Clear the list
            
            list1.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int i in numbers)
            {
                if (i % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int i = numberList.Count-1; i>= 0; i--)
            {
                if (numberList[i] % 2 != 0) 
                { 
                    numberList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (!numberList.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is present");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not present");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i <= 49; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
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
