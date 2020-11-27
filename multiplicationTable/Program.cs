using System;

namespace multiplicationTable
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] multiArr(int num)
            {
                int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] newArr = new int[10];
                for (int i = 0; i < oneToTen.Length; i++)
                {
                    newArr[i] = (oneToTen[i] * (num));
                }
                return newArr;
            }

            int[] arr1 = multiArr(1);
            int[] arr2 = multiArr(2);
            int[] arr3 = multiArr(3);
            int[] arr4 = multiArr(4);
            int[] arr5 = multiArr(5);
            int[] arr6 = multiArr(6);
            int[] arr7 = multiArr(7);
            int[] arr8 = multiArr(8);
            int[] arr9 = multiArr(9);
            int[] arr10 = multiArr(10);

            int[][] multArr = new int[10][]
                {
                arr1 , arr2, arr3, arr4, arr5, arr6, arr7, arr8, arr9, arr10
                };
            foreach (int[] innerArr in multArr)
            {
                Console.WriteLine($"[{innerArr[0]}, {innerArr[1]}, {innerArr[2]}, {innerArr[3]}, {innerArr[4]}, {innerArr[5]}, {innerArr[6]}, {innerArr[7]}, {innerArr[8]}, {innerArr[9]}]");
            }

        }
    }
}
