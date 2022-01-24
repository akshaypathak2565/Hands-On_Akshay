using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstProject.day12 {
    class DeSerializationDemo {
        static void Main(string[] args) {

            var emp = new Employee();

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fileStream = new FileStream("emp.binary", FileMode.Open,
                FileAccess.Read, FileShare.None);

            try {
                using(fileStream) {

                    // DeSerialization
                    emp = (Employee) formatter.Deserialize(fileStream);
                    Console.WriteLine(emp.Empno);
                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.DeptNo);
                    // Returns 0 since the salary is not serialized
                    Console.WriteLine(emp.Salary);
                }
            } catch (Exception e) {
                Console.WriteLine($"Error : {e.Message}");
            }

        }
    }
}
