namespace FirstProject.day5.OperatorOverloading {
    public class Complex {
        public int x;
        public int y;

        Complex() { }
        public Complex(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public static Complex operator +(Complex c1, Complex c2) {
            var obj = new Complex();
            obj.x = c1.x + c2.x;
            obj.y = c1.y + c2.y;
            return obj;

        }

    }

    class Demo {
        static void Main(string[] args) {
            var obj1 = new Complex(10, 20);
            var obj2 = new Complex(30, 40);
            var obj3 = obj1 + obj2;

            string str = "abc" + "cde";

            Console.WriteLine($"Obj1: x={obj1.x} y={obj1.y}");
            Console.WriteLine($"Obj2: x={obj2.x} y={obj2.y}");
            Console.WriteLine($"Obj3: x={obj3.x} y={obj3.y}");

        }
    }
}