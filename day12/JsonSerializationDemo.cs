using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day12 {

    class Department {
        public int id { get; set; }
        public string location { get; set; }

        public int count { get; set; }
    }

    class JsonSerializationDemo {
        static void Main(string[] args) {

            Department department = new Department() {
                id = 101,
                location = "Noida",
                count = 500
            };

            // JSON Serialization
            var jsonData = JsonConvert.SerializeObject(department);

            Console.WriteLine("JSON Serialization Success");
            Console.WriteLine($"Data: {jsonData}");

            var dept = JsonConvert.DeserializeObject<Department>(jsonData);

            Console.WriteLine($"Department ID: {dept.id}");
            Console.WriteLine($"Department Location: {dept.location}");
            Console.WriteLine($"Employee Count: {dept.count}");

        }
    }
}
