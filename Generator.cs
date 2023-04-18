/*
Name: Linyun Liu
Title: Random integer generator
 */
using System.Text;

namespace DataGenerator
{
    class Generator
    {
        static void Main(string[] args)
        {
            Generate(100, 100, "data0.txt");
            Generate(1000, 1000, "data1.txt");
            Generate(10000, 10000, "data2.txt");
        }
        private static void Generate(int itemCount, int range, String name)
        {
            using (FileStream fs = File.Create("/path/to/dir/"+name))
            {
                Random random = new Random();
                String[] array = new string[itemCount];
                // This part is to generate random integers and fill it in an array
                for (int i = 0; i < itemCount; i++)
                {
                    array[i] = random.Next(range) + "\n";
                }
                // Write all the contents in the array to a data file
                var content = string.Concat(array);
                byte[] info = new UTF8Encoding(true).GetBytes(content);
                fs.Write(info, 0, info.Length);
                fs.Dispose();
                Console.WriteLine("File Created!");
            }
        }
    }
}