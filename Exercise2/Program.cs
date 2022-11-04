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
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        void merge(int low, int mid, int high)
        {
            int i, j, k;
            i = low;
            j = mid + 1;
            k = low;
            while ((i <= mid) && (j <= high))
            {
                if (arr[i] <= arr[j])
                {
                    sorted[k++] = arr[i++];
                }
                else
                {
                    sorted[k++] = arr[j++];
                }
                cmp_count++;
            }
            while (i <= mid)
            {
                sorted[k++] = arr[i++];
                mov_count++;
            }
            while (j <= high)
            {
                sorted[k++] = arr[j++];
                mov_count++;
            }
            for (i = low; i <= high; i++)
            {
                arr[i] = sorted[i];
                mov_count++;
            }
        }
        void m_sort(int low, int high)
        {
            int mid;
            if (low >= high)
                return;
            mid = (low + high) / 2;
            m_sort(low, mid);
            m_sort(mid + 1, high);
            merge(low, mid, high);
        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine(" Sorted array Element");
            Console.WriteLine("-------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j] + "\n");
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);
        }
    }
}