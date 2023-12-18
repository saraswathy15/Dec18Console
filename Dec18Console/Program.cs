using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class Program
    {
        static void SingleArray()
        {
            int[] nums = { 66, 3, 5, 45 };
            int avg = 0;
            for (int i = 0; i < 4; i++)
            {
                avg = avg + nums[i];
                avg = avg / 4;
                Console.WriteLine("average of numbers " + avg);

            }
        }
        static void RectangularArry()
        {
            int t, j;
            int[,] nums = new int[3, 4];
            for (t = 0; t < 3; t++)
            {
                for (j = 0; j < 4; j++)
                {
                    nums[t, j] = (t * 4) + j + 1;
                    Console.WriteLine(nums[t, j] + " ");
                    //Console.WriteLine("{0} * {1} = {2}", nums[t, j], nums[t,j],);
                }
            }
        }
        static void JaggedArry()
        {
            int[][] jaggedArray = {
         new int[] {1, 9, 5},
         new int[] {2, 4},    };
            // print elements of jagged array
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);
            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            // SingleArray();
            //  RectangularArry();
            // JaggedArry();
            //AllCollections.ArrayListFuns();
            // AllCollections.HashTableFuns();
            // AllCollections.SortedListFuns();
            AllCollections.StackFuns();
            AllCollections.QuequeFuns();
            Console.WriteLine("hello");
            Console.ReadLine();
        }
    }
}