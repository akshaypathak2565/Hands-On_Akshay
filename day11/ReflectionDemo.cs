using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FirstProject.day11 {

    interface IPerson {
        void showPerson();
    }

    class Person : IPerson {
        
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age) {
            this.Name = name;
            this.Age = age;
        }

        public void showPerson() {
            Console.WriteLine($"Name: {Name}\nAge : {Age}");
        }

        public void setPerson(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
    }

    class ReflectionDemo {

        static void Main(string[] args) {

            var p = new Person("Harsh", 24);

            //Type t = p.GetType();

            //Type t = Type.GetType("FirstProject.day11.Person", false, true);

            Type t = typeof(Person);

            //Console.WriteLine(t);

            getTypeDetails(t);

        }

        public static void getTypeDetails(Type t) {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{t.Name} Type Details:");
            sb.AppendLine($"Full Name : {t.FullName}");
            sb.AppendLine($"Namespace : {t.Namespace}");

            var bt = t.BaseType;

            if (bt != null)
                sb.AppendLine($"Base Type : {bt.Name}");

            sb.AppendLine($"Is Abstract class : {t.IsAbstract}");
            sb.AppendLine($"Is Array : {t.IsArray}");
            sb.AppendLine($"Is Class : {t.IsClass}");

            MemberInfo[] members = t.GetMembers();
            foreach(var member in members) {
                sb.AppendLine($"{member.Name} ({member.MemberType})");
            }

            MethodInfo[] methods = t.GetMethods();
            foreach(var method in methods) {
                sb.AppendLine($"{method.Name} ({method.MemberType})");
                sb.AppendLine($"Parameters used by the {method.Name}:");

                ParameterInfo[] parameters = method.GetParameters();
                foreach(var parameter in parameters) {
                    sb.AppendLine($"{parameter.Name} : {parameter.ParameterType}");
                }

                sb.AppendLine("---------");
            }

            Console.WriteLine(sb.ToString());
        }

    }
}
