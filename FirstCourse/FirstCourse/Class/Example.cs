using System;
namespace FirstCourse.Class
{
    //  Create a class 
    // Access Modifier(Who can access to this class)  "public", class key word "class", identifier "Name"

    public class Person
    {
        // Fields
        public string Name;


        // Method
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name);
        }


       /* // Create Object
        int number;

        Person person = new Person();//  "new Person();" Explicitly allocate memory for them
        person.Name = "Mosh";
        */
    }
}
