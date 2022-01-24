using System;

namespace FirstProject.day13.designPattern.ISP {
    
    interface IPrinter {
        public void PrintCopy();
    }

    interface IScanner {
        public void ScanCopy();
    }

    interface IXerox {
        public void XeroxCopy();
    }

    class DotMatrixPrinter : IPrinter {
        public void PrintCopy() {
            Console.WriteLine("Print Copy");
        }
    }

    class InkJetPrinter : DotMatrixPrinter, IScanner {

        public void ScanCopy() {
            Console.WriteLine("Scan Copy");
        }
    }

    class LaserPrinter : InkJetPrinter, IXerox {

        public void XeroxCopy() {
            Console.WriteLine("Xerox Copy");
        }
    }

    class Demo {
        static void Main(string[] args) {

            var dotPrinter = new DotMatrixPrinter();
            dotPrinter.PrintCopy();

            Console.WriteLine("-------------");

            var inkPrinter = new LaserPrinter();
            inkPrinter.PrintCopy();
            inkPrinter.ScanCopy();

            Console.WriteLine("-------------");

            var laserPrinter = new LaserPrinter();
            laserPrinter.PrintCopy();
            laserPrinter.ScanCopy();
            laserPrinter.XeroxCopy();

        }
    }
}
