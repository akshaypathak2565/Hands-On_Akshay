using System;

namespace FirstProject.day9.GenericClass {

    class MyGenericClass<T> {

        private T[] arr;

        public MyGenericClass(int size) {  
            arr = new T[size];
        }

        public void add(int i, T val) {
            arr[i] = val;
        }

        public T[] getItems() {
            return this.arr;
        }

    }

    class Demo {
        static void Main(string[] args) {

            MyGenericClass<int> array = new MyGenericClass<int>(5);
            int val = 10;
            for(int i=0; i<5; i++) {
                array.add(i, val);
                val += 10;
            }

            foreach(int item in array.getItems()) {
                Console.WriteLine(item);
            }
 
        }
    }
}
