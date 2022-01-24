using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day12 {
    [Serializable]
    class Employee {
        public int Empno { get; set; }
        public string Name { get; set; }

        public int DeptNo { get; set; }

        [NonSerialized]
        public decimal Salary;
    }
}
