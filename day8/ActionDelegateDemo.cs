using System;

// Action Delegate never return values, whereas FunDelegate always returns a value

namespace FirstProject.day8.ActionDelegate {

    // custom action delegate
    delegate void GetNameDelegate(string fname, string lname);

    class Demo {
        static void Main(string[] args) {
            // using custom delegate
            GetNameDelegate getFullName2 = new GetNameDelegate(ShowFullName);

            Action<string, string> getFullName = new Action<string, string>(ShowFullName);

            getFullName("harsh", "kumar");
            getFullName2("John", "deo");
        }

        public static void ShowFullName(string fname, string lname) {
            Console.WriteLine($"Full Name: {fname} {lname}");
        }
    }
}
