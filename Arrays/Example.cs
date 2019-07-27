using System;
namespace HelloWorld.Arrays
{
    public class Example
    {
        static void Main(string[] arg)
        {
            // Array represent a fixed numbers of Var of a particular type

            // 1. Type Array Single Dimension
            var numbers = new int[5] { 1, 2, 3, 4, 5 }; // init Array upon Declopation 

            // 2. Multy Dimension

                // Rectangular - each row has the exact same numbers of coloms

            // 2D
            var matrix = new int[3, 5];
            var matrixInit = new int[3, 5] {
                { 1, 2, 3, 4, 5},
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            var element = matrix[0, 0];

            // 3D
            var color = new int[3, 5, 4];



            // Jagged   - number of colomns in each can be diff
            var array = new int[3][];
            array[0] = new int[4];
            array[1] = new int[5];

            array[0][0] = 1;



        }
    }
}
