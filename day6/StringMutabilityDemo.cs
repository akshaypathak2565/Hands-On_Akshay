using System;
using System.Text;


namespace FirstProject.StringMutability {
    internal class Demo {
        static void Main(string[] args) {
            String str = "Harsh";
            String str2 = str;

            Console.WriteLine("str == str2" + Object.ReferenceEquals(str, str2));
            Console.WriteLine("str Address : " + str.GetHashCode());
            Console.WriteLine("str2 Address : " + str2.GetHashCode());

            str += " Kumar";

            Console.WriteLine("str == str2" + Object.ReferenceEquals(str, str2));
            Console.WriteLine("str Address : " + str.GetHashCode());
            Console.WriteLine("str2 Address : " + str2.GetHashCode());

            Console.WriteLine("---------------------------");


            StringBuilder sb = new StringBuilder("hello");
            sb.Append(" world");

            Console.WriteLine(sb);

        }
    }
}
