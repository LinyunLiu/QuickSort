/*
Name: Linyun Liu
Title: Quick Sort algorithm in C#
 */
using System.Text;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort Algorithm"+"\n");
            
            // To read the data file and fill the array with unsorted integers
            int[] array = new int[10000];
            using (StreamReader file = File.OpenText("/path/to/dir/data2.txt"))
            {
                String str;
                int index = 0;
                while ((str = file.ReadLine()) != null)
                {
                    array[index] = int.Parse(str);
                    index++;
                }
            }
            
            // Sort and print the result
            QuickSort(array, 0, array.Length - 1);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            
            // This part of code is to write the sorted array to a new file
            using (FileStream fs = File.Create("/Users/linyunliu/Desktop/data2_sorted.txt"))
            {
                var content = string.Join("\n", array);
                byte[] info = new UTF8Encoding(true).GetBytes(content);
                fs.Write(info, 0, info.Length);
                fs.Dispose();
                Console.WriteLine("Sorted File Created!");
            }
        }


        private static void QuickSort(int[] array, int start, int end)
        {
            // If the sorting is completed, we should terminate the recursion
            if (end <= start)
            {
                return;
            }
            // the previous pivot is essential to determine the next start and end
            int pivot = Sort(array, start, end);
            // To sort the left half and the right half
            QuickSort(array, start, pivot-1);
            QuickSort(array, pivot+1, end);
        }
        private static int Sort(int[] array, int start, int end)
        {
            // This is the pivot index and value
            // In this case we choose the last value in an array as pivot
            int pivot = array[end];
            int j = start-1;
            int temp;

            for (int i = start; i <= end; i++)
            {
                if (array[i] < pivot)
                {
                    // This part is to swap value with the help of a temp variable
                    j++;
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }

            // When we reaches the end of array, lets swap the pivot to the correct position
            j++;
            temp = array[j];
            array[j] = pivot;
            array[end] = temp;

            return j;
        }
    }
}