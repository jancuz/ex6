using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void NextElement(int n, int tecN, ref double[] arr)  // подсчет следующего элемента последовательности
        {
            if (tecN < n)
            {
                double temp = 13 * arr[tecN - 1] - 10 * arr[tecN - 2] + arr[tecN - 3];
                arr[tecN] = temp;
                tecN++;
                Console.Write(temp + " ");
                NextElement(n, tecN, ref arr);
            }
        }

        static bool IsGrowing(int n, double[] arr)  // определение возрастающей последовательности
        {
            for (int i = 1; i < n - 2; i += 2)
                if (arr[i] > arr[i + 2])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
