using System;

namespace FirstProject.day4.Automatic {
    class Employee {
        // Automatic getter setter for variables
        public int _Id { get; set; }
        public string _Name { get; set; }
        
    }

    class Developer: Employee {
        public decimal _Salary { get; set; }
    }

    class Demo {
        public static void Main(string[] args) {
            Employee employee = new Employee();
            employee._Name = "Harsh Kumar";
            employee._Id = 104;

            Developer developer = new Developer();
            developer._Name = "John Deo";
            developer._Salary = 12345.00m;
            developer._Id = 145;


            Console.WriteLine(employee._Name);
            Console.WriteLine(employee._Id);

            Console.WriteLine(developer._Id);
            Console.WriteLine(developer._Name);
            Console.WriteLine(developer._Salary);
        }
    }
}
