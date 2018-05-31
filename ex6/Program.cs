using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

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
            double a1 = AskData.ReadDoubleNumber("Введите первое чсило последовательности: ", double.MinValue, double.MaxValue);
            double a2 = AskData.ReadDoubleNumber("Введите второе число последовательности: ", double.MinValue, double.MaxValue);
            double a3 = AskData.ReadDoubleNumber("Введите третье число последовательности: ", double.MinValue, double.MaxValue);
            int n = AskData.ReadIntNumber("Введите границу последовательности: ", int.MinValue, int.MaxValue);

            double[] arr = new double[n];   // массив элементов последовательноти
            // первые три элемента заданной последовательности
            arr[0] = a1;
            arr[1] = a2;
            arr[2] = a3;

            Console.Write("Последовательность: {0} {1} {2} ", a1, a2, a3);
            int tecN = 3;
            NextElement(n, tecN, ref arr);  // получение элементов последовательности
            Console.WriteLine();
            if (!IsGrowing(n, arr))  // определение, являются ли элементы, стоящие на четных местах, возрастающей последвательностью 
                Console.WriteLine("Элементы, стоящие на четных местах, не образуют возрастающую подпоследовательность");
            else
                Console.WriteLine("Элементы, стоящие на четных местах, образуют возрастающую подпоследовательность");
        }
    }
}
