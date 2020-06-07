using System;

namespace lab1
{
    public class Lib1
    {
        public string stpow(string a, int b)
        {
            string res = "";

            for (int i = 0; i < b; i++)
            {
                res += a;
            }
            return res;
        }

        public string rev(string a)
        {
            string res = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                res += a[i];
            }
            return res;
        }

        public string remov(string str, string s)
        {
            return str.Replace(s, "");
        }

        public int leng(string str)
        {
            return str.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lib1 k = new Lib1();

            Console.WriteLine(k.stpow("ha", 4));
            Console.WriteLine(k.rev("I need termal clips!"));
            Console.WriteLine(k.remov("xriithiasdii", "i"));
            Console.WriteLine(k.leng("They all are gone"));
        }
    }
}
