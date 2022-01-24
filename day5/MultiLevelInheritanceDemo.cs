using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day5.MultiLevelInheritance {
    public class GrandParents {
        public GrandParents() {
            Console.WriteLine("Grand Parents Constructor Invoked");
        }
        public virtual void MyMethod() {
            Console.WriteLine("MyMethod Definition at the GrandParents Class");
        }
    }

    public class Parents : GrandParents {
        public Parents() {
            Console.WriteLine("Parents Constructor Invoked");
        }
        public override void MyMethod() {
            Console.WriteLine("MyMethod Definition at the Parents Class");
        }
    }

    public class GrandChildren : Parents {
        public GrandChildren() {
            Console.WriteLine("Grand Children Constructor Invoked");
        }
        public override void MyMethod() {
            Console.WriteLine("MyMethod Definition at the GrandChildren Class");
        }
    }

    internal class Demo {

        public static void Main(string[] args) {
            var gp = new GrandParents();
            gp.MyMethod();
            Console.WriteLine("----------------");
            var p = new Parents();
            p.MyMethod();
            Console.WriteLine("-----------------");
            var gc = new GrandChildren();
            gc.MyMethod();
        }
    }
}
