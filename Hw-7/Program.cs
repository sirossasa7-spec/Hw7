using System;

namespace Hw_7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class Array : IOutput
    {
        private int[] numbers;

        public Array(int[] arr)
        {
            numbers = arr;
        }

        public void Show()
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array(new int[] { 5, 8, 2, 9, 1 });

            arr.Show();

            arr.Show("Мій масив:");

            Console.ReadKey();
        }
    }
}