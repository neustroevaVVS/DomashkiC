using System;

namespace zadanie3
{
    class Program
    {
        static void MinArrayElement(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -10 + rand.Next() % 20;
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine();

            int min = arr[0];
            int modul;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min < 0) min *= -1;

                modul = arr[i];

                if (modul < 0) modul *= -1;

                if (modul < min) min = modul;
            }
            Console.Write(min);
            Console.WriteLine("\n");
        }


        static void UniqueElement(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -10 + rand.Next() % 20;
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine();

            int num = 0;
            int k = 0;

            Console.Write("Уникальные элементы: ");

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        num = arr[j];
                    }
                }

                if (count == 1)
                {
                    Console.Write(num + " | ");
                    k++;
                }
                else num = 0;
            }
            if (k == 0) Console.WriteLine("Нет уникальных элементов");
            Console.WriteLine("\n");
        }


        static void DeleteNegative(int[] arr)
        {
            Random rand = new Random();

            int[] arr1 = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -10 + rand.Next() % 20;
                Console.Write(arr[i] + " | ");
            }
            Console.WriteLine();
            Console.Write("Положительные элементы: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0) arr1[i] = arr[i];
                else continue;
                Console.Write(arr1[i] + " | ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("First: ");
            int[] arr = new int[10];
            MinArrayElement(arr);

            //2
            Console.WriteLine("Second: ");
            UniqueElement(arr);

            //3
            Console.WriteLine("Third: ");
            DeleteNegative(arr);
        }
    }
}
