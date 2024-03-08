using System.Diagnostics.CodeAnalysis;

namespace _8_mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vyvedi celi chisla: ");
           
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int swapVar = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swapVar)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;
                if (index <= 0)
                {
                    Console.WriteLine();

                }
                
                

            }

            Console.WriteLine(string.Join(", ", arr));
            




        }
    }
}
