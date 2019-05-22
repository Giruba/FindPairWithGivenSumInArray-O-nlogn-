using System;
using System.Collections.Generic;
using System.Text;

namespace FindPariWithGivenSumInArray
{
    class InputProcessor
    {

        public static int[] GetArrayFromInput() {

            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements in the array separated by space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ',',',';');
                array = new int[numberOfElements];
                for (int index = 0; index < numberOfElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("InputProcessor:GetArrayFromInput: Thrown exception is "+exception.Message);
            }
            return array;
        }

        public static void PrintPairsWithGivenSum(int[] array, int givenSum)
        {

            //Sort the array
            Array.Sort(array);

            int lowIndex = 0;
            int highIndex = array.Length - 1;
            while (lowIndex < highIndex)
            {
                if (array[lowIndex] + array[highIndex] == givenSum)
                {
                    Console.WriteLine("A pair with the given sum " + givenSum +
                        " is found [" + array[lowIndex] + "," + array[highIndex] + "]");
                    lowIndex++;
                    highIndex--;
                }
                else if (array[lowIndex] + array[highIndex] < givenSum)
                {
                    lowIndex++;
                }
                else if (array[lowIndex] + array[highIndex] > givenSum)
                {
                    highIndex--;
                }
            }
        }
    }
}
