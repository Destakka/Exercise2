using System;

namespace Exercise2
{
    class List
    {
        private int[] arr = new int[20];
        private int[] sorted = new int[20];
        private int cmp_count, mov_count, n;
        public List()
        {
            cmp_count = 0;
            mov_count = 0;
        }
        void read()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of element in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 20 elements. \n");
            }

        }
    }
}