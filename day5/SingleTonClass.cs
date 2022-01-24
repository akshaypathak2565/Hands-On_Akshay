
namespace FirstProject.day5.SingleTonClass {

    public sealed class MySingleTonClass {
        private static int count = 0;
        private static MySingleTonClass instance = null;

        public static MySingleTonClass GetInstance {
            get {
                if (instance == null) {
                    instance = new MySingleTonClass();
                }

                return instance;
            }
        }

        private MySingleTonClass() {
            count++;
            Console.WriteLine($"MySingleTon class Instance created for {count} times");
        }

        public void show() {
            Console.WriteLine("Show method in MySingleTonClass");
        }
    }


    class Demo {
        static void Main(string[] args) {
            var obj1 = MySingleTonClass.GetInstance;
            obj1.show();

            var obj2 = MySingleTonClass.GetInstance;
            obj2.show();
        }
    }
}
