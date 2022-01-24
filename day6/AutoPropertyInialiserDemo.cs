using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day6.AutoPropertyInialiser {
    
    class Employee {
        //private Guid _id;
        //public Employee() {
        //    _id = Guid.NewGuid();
        //}

        //public Guid Id {
        //    get { return this._id; }
        //}

        //public string Ename { get; set; }
        //public decimal Salary { get; set; }

        public Guid _id { get; } = Guid.NewGuid();
        public string Ename { get; set; } = "Default Name";

        public Decimal Salary { get; set; } = 500;

    }

    class Demo {
        static void Main(string[] args) {
            Employee emp = new Employee() {
                Ename = "First", Salary = 10000
            };
            // emp._id = "EMP101";
            Console.WriteLine($"Employee # : {emp._id}");
            Console.WriteLine($"Employee Name : {emp.Ename}");
            Console.WriteLine($"Salary : Rs. {emp.Salary}");

            Console.WriteLine("----------------");

            Employee emp2 = new Employee();
            // emp2._id = "EMP101";
            Console.WriteLine($"Employee # : {emp2._id}");
            Console.WriteLine($"Employee Name : {emp2.Ename}");
            Console.WriteLine($"Salary : Rs. {emp2.Salary}");

        }
    }
}
