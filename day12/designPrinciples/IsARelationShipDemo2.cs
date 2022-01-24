using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day12.designPrinciples.IsARelationShip {

    public abstract class Shape {
        public abstract void GetShape();
    }

    class RectangleShape : Shape {
        public override void GetShape() {
            Console.WriteLine("I am a Rectangle");
        }
    }

    class SquareShape : Shape {
        public override void GetShape() {
            Console.WriteLine("I am a Square");
        }
    }

    class Demo2 {
        static void Main(string[] args) {
            Shape shape = new RectangleShape();
            shape.GetShape();

            shape = new SquareShape();
            shape.GetShape();
        }
    }
}
