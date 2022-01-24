
namespace FirstProjectday4.day4 .Shadowing {
    class Parent {
        public void fun() {
            Console.WriteLine("Fun from Parent");
        }
    }

    class Child : Parent {
        public new void fun() {
            Console.WriteLine("Fun from Child");
        }
    }

    class Demo {
        public static void Main(string[] args) {
            Child child = new Child();
            child.fun(); // Fun from Child
            Parent parent = new Child();
            parent.fun(); // Fun from Parent
        }
    }
}
