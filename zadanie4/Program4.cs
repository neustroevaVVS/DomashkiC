using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList() { 12, 27.3, 3, "e", 7.7, "t", "S", "A", 777, 1, "j", "H", 55, 14.5, 0 };
            ArrayList objUpper = new ArrayList(100);

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < obj.Count; i++)
            {
                if (obj[i] is string)
                {
                    obj.RemoveAt(i);
                    if (obj[i] is string) i--;
                }
            }

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
        }
    }
}
