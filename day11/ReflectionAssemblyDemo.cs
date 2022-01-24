using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day11 {
    internal class ReflectionAssemblyDemo {

        static void Main(string[] args) {

            // Load the current running Assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // retrieves the class which has to be used in our application
            Type person = assembly.GetType("FirstProject.day11.Person");

            // creating instance of an person class
            var p = Activator.CreateInstance(person);

            // Defining the parameters for setPerson method
            MethodInfo setPerson = person.GetMethod("setPerson");

            object[] parameters = new object[2];
            parameters[0] = "Harsh";
            parameters[1] = 24;

            setPerson.Invoke(p, parameters);

            MethodInfo showPerson = person.GetMethod("showPerson");
            showPerson.Invoke(p, null);

        }

    }
}
