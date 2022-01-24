using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstProject.day12 {
    class SerializationDemo {

        static void Main(string[] args) {
            Employee emp = new Employee() {
                Empno = 101,
                Name = "Harsh",
                DeptNo = 4,
                Salary = 10000
            };

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("emp.binary", FileMode.Create,
                FileAccess.Write, FileShare.None);

            try {
                using(stream) {
                    // Serialization
                    formatter.Serialize(stream, emp);
                    Console.WriteLine("Employee Object Serialized");
                }
            } catch (Exception e) {
                Console.WriteLine($"Error : {e.Message}");
            }

        }

    }
}
