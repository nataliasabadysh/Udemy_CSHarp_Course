using System;
namespace FirstCourse
{
    public class Variables2
    {
        public static void Main(string[] args)
        {
            // Implicit Type Conversion

            byte b = 1; // 0001  
            int i = b;  // 0000 0000 0000 0001

            int s = 1;
            float f = s;


            // Explicit Type Conversion - Casting
            

            //int w = 1;
            //byte d = w; //  won't compile

            int w = 1;
            byte d = (byte)w; // casting

            float p = 1.0f;
            int l = (int)p; // we aware of the data loss and we still want to convert P to the int


            // Types Non-Compatible

            // string str = "1";
            // int num = (int)s; won't compile


            string str = "1";
            int intNum = Convert.ToInt32(s); 
            int j = int.Parse(str); // takes string and tries to convert to int

            // ToByte();
            // ToInt16(); 
            // ToInt32();
            // ToInt64();


        }
    }
}
