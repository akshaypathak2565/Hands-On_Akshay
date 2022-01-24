using System;

namespace FirstProject.day4.Inheritance {

    class BaseClass {
        protected string name = "Harsh";
        public BaseClass() {
            Console.WriteLine("Base class default constructor");
        }
        public BaseClass(string str) {
            Console.WriteLine(str);
            Console.WriteLine("Base class parameterized constructor");
        }
    }

    class DerivedClass : BaseClass {
        public DerivedClass() {
            Console.WriteLine("Dervied class default constructor");
        }
        public DerivedClass(string str) : base(str) {
            Console.WriteLine("Derived class parameterized constructor");
        }

        public void fun() {
            Console.WriteLine(name);
        }
    }

    class Demo {
        public static void Main(string[] args) {
            DerivedClass obj = new DerivedClass("Hello");

            obj.fun();
        }
    }
}
