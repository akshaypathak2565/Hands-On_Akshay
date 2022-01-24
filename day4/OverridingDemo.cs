using System;

namespace FirstProject.day4.Overriding {
    class Parent {
        public virtual void fun() {
            Console.WriteLine("Fun from Parent");
        }
    }

    class Child : Parent {
        public override void fun() {
            Console.WriteLine("Fun from Child");
        }
    }

    class Demo {
        static void Main(string[] args) {
            Child child = new Child();
            child.fun(); // Fun from Child
            Parent parent = new Child();
            parent.fun(); // Fun from Child
        }
    }
}