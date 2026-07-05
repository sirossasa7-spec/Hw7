namespace Hw_7
{
    internal class Task3
    {
        interface ISort
        {
            void SortAsc();
            void SortDesc();
            void SortByParam(bool isAsc);
        }

        class Array : ISort
        {
            private int[] numbers;

            public Array(int[] arr)
            {
                numbers = arr;
            }

            public void SortAsc()
            {
                System.Array.Sort(numbers);
            }

            public void SortDesc()
            {
                System.Array.Sort(numbers);
                System.Array.Reverse(numbers);
            }

            public void SortByParam(bool isAsc)
            {
                if (isAsc)
                    SortAsc();
                else
                    SortDesc();
            }

            public void Show()
            {
                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                Array arr = new Array(new int[] { 5, 8, 2, 9, 1 });

                arr.SortAsc();
                Console.WriteLine("За зростанням:");
                arr.Show();

                arr.SortDesc();
                Console.WriteLine("За спаданням:");
                arr.Show();

                arr.SortByParam(true);
                Console.WriteLine("SortByParam(true):");
                arr.Show();
            }
        }
    }
}
