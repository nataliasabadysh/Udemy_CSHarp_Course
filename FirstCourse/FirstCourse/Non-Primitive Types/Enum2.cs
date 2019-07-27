using System;
namespace FirstCourse.NonPrimitiveTypes
{
    public class Enum2
    {
        public static void Main(string[] args)
        {

            var method = ShippingMethod.Express;
            

            Console.WriteLine((int)method); // 3

            // Covert type

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID); // Express


            // To String
            Console.WriteLine( method.ToString() ); // Express


            // String conver to Enum
            // Parsing - String converting to diff type


            var methodName = "Express";

            // Type this Var is 'ShippingMethod' 
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            
            // Class 
            Console.WriteLine(methodName); // Express

        }

        // Use enum number of related constans - enum - type is intager 
        public enum ShippingMethod
        {
            RedularAitrMail = 1,
            RegisterAitrMail = 2,
            Express = 3,
        }   
    }
}
