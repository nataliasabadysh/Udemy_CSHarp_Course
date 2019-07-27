using System;
namespace FirstCourse.NonPrimitiveTypes
{
    public class Enum
    {
        public static void Main(string[] args)
        {
            // consts 
            const int RedularAitrMail = 1;
            const int RegisterAitrMail = 2;
            const int Express = 3;


            var method = ShippingMethod.Express;

        }
    }
    // Use enum number of related constans
    public enum ShippingMethod
    {
        RedularAitrMail = 1,
        RegisterAitrMail = 2,
        Express = 3,
    }
}
