using System;

namespace FirstProject.day9 {
    class GenericMethodsDemo {

        static void Main(string[] args) {

            int a = 10;
            int b = 20;

            Console.WriteLine($"Before Swap: \na={a}\nb={b}");
            Swap<int>(ref a,ref b);
            Console.WriteLine($"Before Swap: \na={a}\nb={b}");

            Console.WriteLine("\n--------------------\n");

            string str1 = "First";
            string str2 = "Second";
            Console.WriteLine($"Before Swap: \nstr1={str1}\nstr2={str2}");
            Swap<string>(ref str1, ref str2);
            Console.WriteLine($"Before Swap: \nstr1={str1}\nstr2={str2}");

        }

        public static void Swap<T>(ref T t1,ref T t2) {

            T tmp = t1;
            t1 = t2;
            t2 = tmp;

        }

    }
}
