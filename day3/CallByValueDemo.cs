using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day3.CallByValue {

    class Name {
        private string _FirstName, _LastName;
        public void setName(string fname, string lname) {
            this._FirstName = fname;
            this._LastName = lname;
        }
        public string getName() {
            return $"{_FirstName} {_LastName}";
        }
    }


    class Demo {
        public static void Main(string[] args) {
            Name name = new Name();
            name.setName("Sekhar", "Srinivas");
            string fullName = name.getName();
            Console.WriteLine($"Name : {fullName}");
        }
    }
}
