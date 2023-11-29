using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //FindNumber();
                //MidleNumbers();
                Console.ReadKey();
            }
            /// <summary>
            /// поиск среднего арифметического и вывод его
            /// </summary>
            private static void MidleNumbers()
            {

                Random rnd = new Random();
                Console.WriteLine("введите размер массива");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                int[] resultms = new int[size];
                int y = 0;
                for (int i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(1, 50);
                    int sum = 0;
                    Console.WriteLine(arr[i]);
                    for (int j = 0; j < size; j++)
                    {
                        sum += arr[j];
                        resultms[i] = sum;
                    }

                }


                double mid = resultms[size - 1] / size;
                Console.WriteLine($"среднее арифмтическое {mid}");
                for (int g = 0; g < size; g++)
                {
                    if (arr[g] < mid)
                    {
                        y++;
                       
                        Console.WriteLine($" {g} элемент меньше среднего арифметического={arr[g]}");
                    }

                }
            Console.WriteLine($"всего эллементов меньше среднего арифметического{y}");
        }

            /// <summary>
            /// поиск числа в массиве
            /// </summary>
            private static void FindNumber()
            {
                int[] arr = new int[0];
                int y = 0;
                for (int i = 1; i <= 20; i++)
                {
                    Array.Resize(ref arr, i + 1);
                    Console.WriteLine($"введите {i} элемент массива");
                    int number = Convert.ToInt32(Console.ReadLine());

                    arr[i] = number;

                }
                Console.WriteLine("введите искомое число");
                int find = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == find)
                    {
                        y++;
                        Console.WriteLine($"{j} эллемент массива содержит число {find}");
                    }
                }
            }
    }
}
