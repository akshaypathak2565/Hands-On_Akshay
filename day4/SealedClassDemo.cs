using System;

namespace FirstProject.day4.SealedClass {

    class BaseClass {
        public void MyMethod() {
            Console.WriteLine("Messsage from C# Session:");
        }
    }
    interface IFace {
        void Says();
    }
    sealed class NotInheritableClass : BaseClass, IFace {
        public void Says() {
            Console.WriteLine("End of C# Fundamentals");
        }
    }
    //class OtherClass : NotInheritableClass
    //{
    //}


    internal class Demo {
        public static void Main(string[] args) {
            NotInheritableClass nic = new NotInheritableClass();
            nic.MyMethod();
            nic.Says();
        }

    }
}
