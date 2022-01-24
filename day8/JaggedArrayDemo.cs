using System;

// Jagged Array

namespace FirstProject.day8.JaggedArray {
    class Demo {
        static void Main(string[] args) {
            // Jagged Array
            int[][] arr = new int[3][];

            arr[0] = new int[3] {1,2,3};
            arr[1] = new int[4] {4,5,6,7};
            arr[2] = new int[5] {8,9,10,11,12};

            for(int r=0; r<arr.Length; r++) {
                for(int c=0; c<arr[r].Length; c++) {
                    Console.Write(arr[r][c] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
