using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

            list = RemoveAll(list, 1);

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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                    return true;
                }
            }
            return false;
        }

        static int Find(int[] array, int find)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == find)
                {
                   return i;
                }
            }

            return -1;
        }

        static int[] RemoveAt(int[] array, int index)
        {
            int[] newArray = { };
            int space = 0;

            if (index > -1 && index < array.Length)
            {
                newArray = new int[array.Length - 1];
            }
            else
            {
                newArray = array;
            }

            if (array.Length > newArray.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < index || i > index)
                    {
                        newArray[space] = array[i];
                        space++;
                    }
                }
            }

            return newArray;
        }

       static int[] Remove(int[] array, int value)
        {
            return RemoveAt(array, Find(array,value));
        }

        static int[] RemoveAll(int[] array, int value)
        {
            while (Contains(array, value))
            {
               array = Remove(array, value); 
            }

            return array;
        }
    }
}
