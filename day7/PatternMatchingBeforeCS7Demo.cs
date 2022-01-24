using System;

namespace FirstProject.day7.PatternMatchingBeforeCS7 {
    
    public class Employee {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
    }

    public class Manager : Employee {
        public string Department { get; set; }
    }

    public class Salesman : Employee {
        public decimal Commission { get; set; }
    }
    
    class Demo {

        public static void GetEmployee(Employee emp) {

            Console.WriteLine($"Employee No: {emp.Empno}");
            Console.WriteLine($"Employee Name: {emp.Ename}");
            Console.WriteLine($"Salary: Rs.{emp.Salary}");

            // Before C# 7.0
            if(emp is Manager) {
                var manager = (Manager) emp;
                Console.WriteLine($"Department: {manager.Department}");
            }

            if(emp is Salesman) {
                var salesman = (Salesman)emp;
                Console.WriteLine($"Commission: {salesman.Commission}");
            }

            Console.WriteLine("------------------");
        }

        static void Main(string[] args) {
            var manager = new Manager() {
                Empno = 101,
                Ename = "First",
                Salary = 10000,
                Department = "Development"
            };

            var salesman = new Salesman() {
                Empno = 102,
                Ename = "Second",
                Salary = 7000,
                Commission = 2000
            };

            GetEmployee(manager);
            GetEmployee(salesman);
        }

    }
}
