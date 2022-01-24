using System;

// Predicate Delegate

namespace FirstProject.day8.PredicateDelegate {
    class Demo {
        static void Main(string[] args) {
            Predicate<string> isCorrectName = new Predicate<string>(CheckName);
            Console.WriteLine(isCorrectName("Ha"));
        }

        public static bool CheckName(string name) {
            if (name != null && name.Length > 4)
                return true;
            return false;
        }

    }
}
