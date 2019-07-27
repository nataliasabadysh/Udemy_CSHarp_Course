using System;
namespace FirstCourse.ValueRefTypes
{
    public class Person
    {
        public int Age;
    }

    class Example2
    {
        public static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.Write(number);// 1


            // Created person obj (var person = new Person();) and initial set its field
            var person = new Person() { Age = 20 };




        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
