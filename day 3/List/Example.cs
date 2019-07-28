using System;
using System.Collections.Generic;

namespace HelloWorld.List
{
    public class Example
    {
        // Creating List - Generic Type < Generyc Parametr(type of the List) >

            // Add()   - add a obj to the list
            // AddRange()  - to add List of obj's
            // Remove()
            // Contains()
            // Count()



        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };  // created List 
            numbers.Add(1); 

            // *  to Array we cann't add element , size cann't be changed
            // in a List we can add/change 

            numbers.AddRange(new int[3] { 5,6, 7});

            // I* Interfase (also we can use Array/list)


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.IndexOf(1);     // 0
            numbers.LastIndexOf(1); // 4

            numbers.Count(); // 8

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[1]);//2, 3, 4, 5
                }

            }

            foreach (var number in numbers)
            {
                Console.Write(number);
            }

            // Removes all element from the list

            numbers.Clear();






        }
    }
}
