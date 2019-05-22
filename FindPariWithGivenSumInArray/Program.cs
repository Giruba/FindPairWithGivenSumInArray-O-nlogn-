using System;

namespace FindPariWithGivenSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find pair with given sum in an array!");
            Console.WriteLine("-------------------------------------");

            try {
                int[] array = InputProcessor.GetArrayFromInput();
                Console.WriteLine("Enter the sum to see if there are two elements in the array that " +
                    "sum up to it");
                int givenSum = int.Parse(Console.ReadLine());
                InputProcessor.PrintPairsWithGivenSum(array, givenSum);
            }catch(Exception exception){
                Console.WriteLine("FindPariWithGivenSumInArray:Program: Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
