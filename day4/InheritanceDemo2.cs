using System;

namespace FirstProject.day4.Inheritance2 {
    class BaseClass {
        public BaseClass() {
            Console.WriteLine($"Base Class Zero Arg Constructor Invoked");
        }
        public BaseClass(string name) {
            Console.WriteLine($"Base Class Parameterized Constructor Invoked by {name}");
        }
    }
    class DerivedClass : BaseClass {
        public DerivedClass() {
            Console.WriteLine("Derived Class Zero Arg. Constructor Invoked");
        }
        public DerivedClass(string name) : base(name) {
            Console.WriteLine($"Derived Class Parameterized Constructor Invoked by {name}");
        }
        public DerivedClass(string fname, string lname) {
            Console.WriteLine($"Derived Class Parameterized Constructor Invoked by {fname} { lname}");
        }
    }
    public class Demo2 {
        public static void Main(string[] args) {
            DerivedClass dc = new DerivedClass();
            DerivedClass dc1 = new DerivedClass("Srinivasan");
            DerivedClass dc2 = new DerivedClass("Sekhar", "Srinivasan");
        }
    }
}
