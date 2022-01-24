using System;

namespace FirstProject.day7.CustomExceptionDemo {
    
    class NameFormatException : Exception {

        string? msg;

        public NameFormatException(string msg) {
            this.msg = msg;
        }

        public override string Message {
            get {
                return msg ?? "Invalid Name";
            }
        }

    }

    class Name {
        string first { get; set; }
        string last { get; set; }

        public Name(string first, string last) {
            if (first.Length < 3 || last.Length < 3)
                throw new NameFormatException("Name Too short");
            if (first is null || last is null)
                throw new NameFormatException("Please! Provide Full name");
        }
    }

    class Demo {
        static void Main(string[] args) {

            Console.WriteLine("Enter First Name");
            string? fName = Console.ReadLine();
            Console.WriteLine("Enter last Name");
            string? lName = Console.ReadLine();

            try {
                Name fullName = new Name(fName, lName);
            } catch (NameFormatException e) {
                Console.WriteLine(e.Message);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Thank you.");
            }


        }
    }
}
