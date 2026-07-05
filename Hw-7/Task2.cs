using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_7
{
    internal class Task2
    {
        interface IMath
        {
            int Max();
            int Min();
            float Avg();
            bool Search(int valueToSearch);
        }

        class Array : IMath
        {
            private int[] numbers;

            public Array(int[] arr)
            {
                numbers = arr;
            }

            public int Max()
            {
                int max = numbers[0];

                foreach (int item in numbers)
                {
                    if (item > max)
                        max = item;
                }

                return max;
            }

            public int Min()
            {
                int min = numbers[0];

                foreach (int item in numbers)
                {
                    if (item < min)
                        min = item;
                }

                return min;
            }

            public float Avg()
            {
                int sum = 0;

                foreach (int item in numbers)
                {
                    sum += item;
                }

                return (float)sum / numbers.Length;
            }

            public bool Search(int valueToSearch)
            {
                foreach (int item in numbers)
                {
                    if (item == valueToSearch)
                        return true;
                }

                return false;
            }
        }

        class Program
        {
            static void Main()
            {
                Array arr = new Array(new int[] { 5, 8, 2, 9, 1 });

                Console.WriteLine("Max = " + arr.Max());
                Console.WriteLine("Min = " + arr.Min());
                Console.WriteLine("Avg = " + arr.Avg());

                Console.WriteLine(arr.Search(8));
                Console.WriteLine(arr.Search(10));
            }
        }
    }
}
