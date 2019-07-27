using System;
namespace FirstCourse.Class
{
    public class Student
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Class
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            var student = new Student();  // instanse of the class, OBJECT 

            student.FirstName = "Will";
            student.LastName = "Smith";
            // Method
            student.Introduce();

            // OBJ
            var calc = new Calc();
             var result = calc.Add(1, 2); 
        }
    }

    public class Calc
    {
        public int Add(int a, int b) {
            return a + b;
        }    
    }
}
