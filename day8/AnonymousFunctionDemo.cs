using System;

namespace FirstProject.day8.AnonymousFunction {
    class Demo {
        static void Main(string[] args) {
            List<string> names = new List<string>();
            names.Add("first");
            names.Add("second");
            names.Add("Third");


            string result2 = names.Find(
                delegate (string name) {
                    return name.Equals("First2");
                });

            string result = names.Find((name) => name.Equals("First"));

            if(result2 == null)
                Console.WriteLine("Name not found");
            else
                Console.WriteLine("Name Found");
        }

    }
}
