using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.CallByRef {
    class Demo {
        //Caller Method
        public static void Main(string[] args) {
            Console.WriteLine("Enter Two Numbers: ");
            int no1 = int.Parse(Console.ReadLine());
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before Swap Method Invoked : {no1}, {no2}");
            Swap(ref no1, ref no2);
            Console.WriteLine($"After Swap Method Invoked : {no1}, {no2}");
        }
        //Called Method
        public static void Swap(ref int no1, ref int no2) {
            int temp = no2;
            no2 = no1;
            no1 = temp;
        }
    }
}
