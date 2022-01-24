using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.OutModeArgument {

    class OuterClass {
        //Called Method
        public void OuterMethod(out int no) {
            // Console.WriteLine($"Recieved Number : {no}");
            no = 1000;
            Console.WriteLine($"After Updating Number within the OuterMethod: {no}");
        }
    }

    class Demo {
        public static void Main(string[] args) {
            int no = 100;
            OuterClass oc = new OuterClass();
            oc.OuterMethod(out no);
            Console.WriteLine($"After OuterMethod Invoked : {no}");
        }

    }
}
