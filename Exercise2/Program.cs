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
            Console.WriteLine("\n-----------------");
            Console.WriteLine(" enter array elements ");
            Console.WriteLine("----------------------");
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
    }
}