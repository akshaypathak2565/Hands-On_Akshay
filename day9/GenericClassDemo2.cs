using System;

namespace FirstProject.day9.GenericClass {

    class Employee {
        public int EmpNo { get; set; }
        public string? EName { get; set; }
        public decimal Salary { get; set; }
    }

    class Department {
        public int DeptNo { get; set; }
    }

    public class DBService<T> {

        T[] arr;
        int pos = 0;

        public DBService(int size) {
            arr = new T[size];
        }

        public void Add(T t) {
            if(pos < arr.Length) {
                arr[pos] = t;
                pos++;
            } else {
                Console.WriteLine("No Space!");
            }
        }

    }

    class Demo2 {
        static void Main(string[] args) {
            DBService<Employee> service1 = new DBService<Employee>(2);
            service1.Add(new Employee());
            service1.Add(new Employee());

            DBService<Department> service2 = new DBService<Department>(1);
            service2.Add(new Department());

        }
    }
}
