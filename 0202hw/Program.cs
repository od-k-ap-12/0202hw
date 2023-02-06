using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0202hw
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            int[] arr = new int[] { 15, 2, 3,0, 4, 27, 6, 7,0, 8, 9,0, 10 };
            int max_odd_element = arr[0];
            int max_odd_element_index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max_odd_element && arr[i] % 2 != 0)
                {
                    max_odd_element = arr[i];
                    max_odd_element_index = i;
                }
            }
            Console.WriteLine(max_odd_element_index);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");

            }
            Console.WriteLine();
            for (int k = 0; k < 3; k++)
            {
                for (int j = max_odd_element_index; j < arr.Length-1; j++)
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i]+" ");

                    }
                    Console.WriteLine();

                }

            }

            #endregion

            #region 2
            int summ = 0;
            int first_zero_index = -1;
            int second_zero_index = -1;
            for (int l = 0; l < arr.Length; l++)
            {
                if (arr[l] == 0)
                {
                    first_zero_index = l;
                    break;
                }
            }
            for (int l = first_zero_index+1; l < arr.Length; l++)
            {
                if (arr[l] == 0)
                {
                    second_zero_index = l;
                    break;
                }
            }
            if (first_zero_index == -1 || second_zero_index == -1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int l = first_zero_index + 1; l < second_zero_index; l++)
                {
                    summ += arr[l];
                }
                Console.WriteLine();

                Console.WriteLine(summ);
            }
            #endregion

            #region 3
            int[] arr2 = new int[] {1,2,3,4,5,6,7,8,9,10};
            int search = 4;
            for (int i = 0; i <arr2.Length-1; i++)
            {
                for(int j = 0; j < arr2.Length - 1; j++)
                {
                    if (arr2[i] + arr2[j] == search)
                    {
                        Console.WriteLine(arr2[i] + " " + arr2[j]);
                    }
                }
            }
            #endregion


        }
    }
}
