namespace FirstProject.day4.Abstract {
    abstract class AbstractClass {
        public void MethodWithDefinition() {
            Console.WriteLine("Method with definition in Abstract class");
        }

        public abstract void MethodWithoutDefinition();
    }

    class OverrideClass : AbstractClass {
        public override void MethodWithoutDefinition() {
            Console.WriteLine("MethodWithoutDefinition with definition in OverrideClass");
        }
    }
    class Demo {
        static void Main(string[] args) {
            OverrideClass obj = new OverrideClass();
            obj.MethodWithDefinition();
            obj.MethodWithoutDefinition();
        }
    }
}
