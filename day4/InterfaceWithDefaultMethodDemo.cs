using System;

namespace FirstProject.day4.InterfaceWithDefaultMethod {

    interface IFace {
        public void MyDefaultMethod() {
            Console.WriteLine("MyDefaultMethod of interface has been implemented at Interface");
        }
        void AbstractMethod();
    }
    class DerivedClass1 : IFace {
        public void AbstractMethod() {
            Console.WriteLine("Abstract Method of interface has been implemented at Derived Class");
        }
    }
    class DerivedClass2 : IFace {
        public void AbstractMethod() {
            Console.WriteLine("Abstract Method of interface has been implemented at Derived Class");
        }
        public void MyDefaultMethod() {
            Console.WriteLine("MyDefaultMethod of interface has been implemented at Derived Class");
        }
    }

    internal class Demo {
        public static void Main(string[] args) {
            //DerivedClass1 dc = new DerivedClass1();
            //dc.MyDefaultMethod();
            //dc.AbstractMethod();
            IFace dc1 = new DerivedClass1();
            dc1.AbstractMethod();
            dc1.MyDefaultMethod();
            DerivedClass2 dc2 = new DerivedClass2();
            dc2.MyDefaultMethod();
            dc2.AbstractMethod();
        }
    }
}
