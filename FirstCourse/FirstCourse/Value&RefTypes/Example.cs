using System;
namespace FirstCourse.ValueRefTypes
{
	public class Example
    {
        public static void Main(string[] args)
        {
            // Value Types

            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a= 10, b = 11


            // Reference Type

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[1])); // both 0

            //  {1, 2, 3,}  Obj created on the Heap

            // array1 - ref to the obj on the Heap
            // array2 have memory address to the obj, on the Heap 

        }
    }
}

