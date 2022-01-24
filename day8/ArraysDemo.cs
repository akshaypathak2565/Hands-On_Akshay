using System;

namespace FirstProject.day8.Arrays {
    class Demo {
        static void Main(string[] args) {
            // Single dimensional array
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            
            for(int i=0; i<arr.Length; i++) {
                Console.Write(arr[i] + ", ");
            }

            Console.WriteLine();

            // or
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            // or
            int[] arr3 = { 10, 20, 30, 40 };

            for (int i = 0; i < arr2.Length; i++) {
                Console.Write(arr2[i] + ", ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr3.Length; i++) {
                Console.Write(arr3[i] + ", ");
            }

        }
    }
}
