using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2425_BaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[0];
            Random rnd = new Random(); 


            list = AddToArray(list, 1);
            list = AddToArray(list, 1);
            list = AddToArray(list, 3);
            list = AddToArray(list, 1);
            list = AddToArray(list, 5);
            list = AddToArray(list, 1);
            list = AddToArray(list, 3);


            DisplayArray(list);

            Console.WriteLine(Contains(list,5));
            Console.WriteLine(Find(list,3));
            list = RemoveAt(list, 5);

            Console.WriteLine();
            DisplayArray(list);

            list = Remove(list,3);

            Console.WriteLine();
            DisplayArray(list);

            Console.ReadKey();
        }

        /// <summary>
        /// This should be the only method used to display the array
        /// </summary>
        /// <param name="array"></param>
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("The current length of the array is " + array.Length);
            Console.WriteLine("It contains the following values:");

            foreach (int i in array)
                Console.Write(i + "\t");

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// This method a value into the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>returns the array with the added value</returns>
        static int[] AddToArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int x = 0; x < array.Length; x++)
            {
                newArray[x] = array[x];
            }

            newArray[array.Length] = value;

            return newArray;
        }

        static bool Contains(int[] array, int find)
        {
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        static int Find(int[] array, int find)
        {
            int location = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                    location = i;
                    break;
                }
            }

            return location;
        }

        static int[] RemoveAt(int[] array, int index)
        {
            Console.WriteLine($"Removing the item in the index of {index}");
            int[] newArray = new int[array.Length - 1];
            int space = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index || i > index)
                {
                    newArray[space] = array[i];
                    space++;
                }
            }

            return newArray;
        }

       static int[] Remove(int[] array, int value)
        {
            Console.WriteLine($"Removing the first instance of {value}");
            int locate = Find(array, value);
            int[] newArray = RemoveAt(array, locate);

            return newArray;
        }
    }
}
