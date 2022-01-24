namespace FirstProject.day4.Interface {

    interface IFather {
        void Loan();
    }

    interface IMother {
        void Loan();
    }

    class Child1 : IFather, IMother {
        void IFather.Loan() {
            Console.WriteLine("Hello Loan - Father");

        }
        void IMother.Loan() {
            Console.WriteLine("Hello Loan - Mother");
        }

        public void display() {
            Console.WriteLine("Disply");
        }

    }

    class Child2 : IFather, IMother {
        public void Loan() {
            Console.WriteLine("Hello Loan - Child2");
        }
    }

    class Demo {
        static void Main(string[] args) {
            IFather father = new Child1();
            father.Loan();

            IMother mother = new Child1();
            mother.Loan();
        }
    }
}