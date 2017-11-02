using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            
            int[] reversed = ReverseArray(source);
            
            foreach (int i in reversed)
                Console.Write(i.ToString() + " ");
            
        }
        
        public static int[] ReverseArray(int[] a)
        {
            int[] reversed = new int[a.Length];
            int index;
            int j; // reversed indexer
            
            for (index = a.Length - 1, j = 0; index >= 0; index--, j++)
            {
                reversed[j] = a[index];
            }
            
            return a = reversed.ToArray();
        }
    }
}
