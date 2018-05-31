using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void NextElement(int n, int tecN, ref double[] arr)
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

        static void Main(string[] args)
        {
        }
    }
}
