using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day5.StaticClass {

    public static class MyClass {
        public static string StaticVariable;
        static MyClass() {
            StaticVariable = "This is a Static Variable";
        }
        public static void MyMethod1() {
            Console.WriteLine("My Static Method MyMethod1");
        }
    }



     class Demo {
        public static void Main(string[] args) {
            Console.WriteLine(MyClass.StaticVariable);
            MyClass.MyMethod1();
            //var mc = new MyClass(); Objects cant be created for the Static Classes
        }
    }
}
