using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_In_.NET
{
    class Program
    {
        Random rnd = new Random(0); //to avoid change we added random (0)
       
        static void Main(string[] args)
        {
            //Console.Write("Enter size of an Array = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];


            ////Generating a random array
            //Random rnd = new Random(0); //to avoid change we added random (0)
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(100);
            //}

            ////output our array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + "\t");
            //}
            //Console.WriteLine();

            //foreach (int i in arr) //Output of our array using foreach
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine();

            ////Finding sum of an array
            ////int sum = 0;
            ////foreach (int i in arr)
            ////{
            ////    sum += i;
            ////}
            ////Console.WriteLine("Sum of element array = " +sum);
            ////Console.WriteLine("Average arithmetical element an array = " + (double)sum/arr.Length);
            //////int min, max;
            //////min = max = arr[0];
            //////foreach (int i in arr)
            //////{
            //////    if (i < min) min = i;
            //////    if (i > max) max = i;
            //////}
            ////Console.WriteLine("Min of element array = " + arr.Min());
            ////Console.WriteLine("Max of element array = " + arr.Max());

            ////STANDARD C# LIBary

            //Console.WriteLine($"Sum of element array:  {arr.Sum()}");
            //Console.WriteLine($"Average arithmetical element an array = {arr.Average()}");
            //Console.WriteLine($"Min of element array =  {arr.Min()}");
            //Console.WriteLine($"Max of element array = {arr.Max()}");
            //Console.WriteLine("After sorting");
            //Array.Sort(arr);
            //foreach(int i in arr) Console.Write(i +"\t"); Console.WriteLine();



            //// 2-Demensional Array
            //Console.Write("Enter row size of an Array = ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter column size of an Array = ");
            //int cols = Convert.ToInt32(Console.ReadLine());
            //int[,] arr_2 = new int[rows, cols];

            //Random rnd = new Random(0);
            //for (int i = 0; i < arr_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr_2.GetLength(1); j++)
            //    {
            //        arr_2[i, j] = rnd.Next(100);
            //    }
            //    Console.WriteLine();
            //}



            //for (int i= 0; i <arr_2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr_2.GetLength(1); j++)
            //    {
            //        Console.Write(arr_2[i, j]+"\t");
            //    }
            //    Console.WriteLine();
            //}

            ////foreach(int i in arr_2)
            ////{

            ////        Console.Write(i + "\t" );
            ////}
            ////Console.WriteLine();

            //Console.WriteLine($" Number of changes in an Array: {arr_2.Rank}");
            //Console.WriteLine($" total number of element in an Array: {arr_2.Length}");
            //Console.WriteLine($" length(stroki) of changes in an Array: {arr_2.GetLength(0)}");
            //Console.WriteLine($" length of changes in an Array: {arr_2.GetLength(1)}");
            //Console.WriteLine($"Sum of element of two demensional array: {arr_2.Cast<int>().Sum()}");
            //Console.WriteLine($"Average  of element of two demensional array: {arr_2.Cast<int>().Average()}");
            //Console.WriteLine($"Min of element of two demensional array: {arr_2.Cast<int>().Min()}");
            //Console.WriteLine($"Max of element of two demensional array: {arr_2.Cast<int>().Max()}");


            //// jagged arrays 
            Console.Write("Enter row size of an Array = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column size of an Array = ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[][] arr_3 =
            {
                new int[]{3, 5, 8, 13, 21},
                new int[] {34, 55, 89},
                new int[]{144, 233, 377, 610}
            };


            //Random rnd = new Random(0);
            //for (int i = 0; i < arr_3.Length; i++)
            //{
            //    for (int j = 0; j < arr_3[i].Length; j++)
            //    {
            //        arr_3[i][j] = rnd.Next(100);
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < arr_3.Length; i++)
                {
                      for (int j = 0; j < arr_3[i].Length; j++)
                      {
                         Console.Write(arr_3[i][j] + "\t");
                      }
                       Console.WriteLine();
                }

            int sum = 0;
            for (int i = 0; i < arr_3.Length; i++)
            {
                for (int j = 0; j < arr_3[i].Length; j++)
                {
                    sum += arr_3[i][j];
                }
                Console.WriteLine();
            }
           
            //int min=0, max=0;
            //for (int i = 0; i < arr_3.Length; i++)
            //{
                 
            //    for (int j = 0; j < arr_3[i].Length; j++)
            //    {
            //        if(min <arr_3[i][j]);
            //        {
            //            arr_3[i][j] = min;
            //        }
            //        if (max > arr_3[i][j]) ;
            //        {
            //            arr_3[i][j] = min;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Sum of element array = " + sum);
            Console.WriteLine($" number of element in an Array: {arr_3.Length}");
            Console.WriteLine("Average arithmetical element an array = " + (double)sum / arr_3.Length);
             Console.WriteLine($" Number of changes in an Array: {arr_3.Rank}");
          //  Console.WriteLine($"Min of element of two demensional array:{arr_3.Cast<int>().Min()}");
           // Console.WriteLine($"Max of element of two demensional array:{arr_3.Cast<int>().Max()}");


        }
    }
}
