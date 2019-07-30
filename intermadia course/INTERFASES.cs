using System;
namespace SecondPart.Intermadia
{
    public class INTERFASES
    {
        // Class is simply a building od software app

        // Object - an instance of the class  (instance of the class thet resides in the memory)


        //  Example
        //  Class  -> Person(name, age, hight, wieght, Walck(). Eat(), Talk(), Sleep()... )
        //  Object -> John , Merry,



        // *****   Declaring Class

        public class Person
        {
            public string Name;     
        }


        public class PersonWithName
        {
            public string Name;

            // ***** Method
            public void Introduce()
            {
                Console.Write("Hi, my name is" + Name);
            }
        }

        // *****  Createing Object (instance of the class )

     /*
        Person person = new Person();   // common notation 

        var person = new Person();      // var 
       
        var person = new Person();      // Using Object
        Person.Name = "Mosh";
        person.Introduce();
     */




        /*
            Class Members

             - Instanse: accessible from an object
                var person = new Person();
                person.Introduce

             - Static: accessible from the class 
                Concole.Write()
        */











    }
}
