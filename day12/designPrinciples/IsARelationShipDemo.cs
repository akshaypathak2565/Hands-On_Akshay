using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.day12.designPrinciples.IsARelationShip {

    class Rectangle {

        public int Height { set; get; }
        public int Width { set; get; }

        public Rectangle(int height, int width) {
            this.Height = height;
            this.Width = width;
        }

        public virtual int Area() {
            return Height * Width;
        }

    }

    class Square : Rectangle {
        public Square(int side) : base(side, side) {}
    }

    internal class Demo {
        static void Main(string[] args) {

            Rectangle rect = new Rectangle(10, 20);
            Rectangle square = new Square(10);

            Console.WriteLine($"Area of Rectangle : {rect.Area()}");
            Console.WriteLine($"Area of Square : {square.Area()}");


        }
    }
}
