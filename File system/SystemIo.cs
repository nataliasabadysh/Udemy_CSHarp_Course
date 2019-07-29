using System;
using System.IO;

namespace SecondPart
{
    public class SystemIo
    {
        public SystemIo()
        {
            public static void Main(string[] args)
            {

                // File  -  provides static method   ( Create,Copy(), Delete(), Exist(), GetAtrebutes(),  Move(), .. )



                // FileInfo - provides instance method



       
                //File.Copy("c:\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg");


                var path = @"c:\\somefile.jpg";

                File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg");

                File.Delete(path);
                if (File.Exists(path)) {  /**/ }

                var content = File.ReadAllBytes(path); // return Byte Arrray


                var fileInfo = new FileInfo(path);   // it is static method in a file class

                fileInfo.CopyTo(" ... ");
                fileInfo.Delete();
                if (fileInfo.Exists) {  /**/ }

                // Directory provides staic method  ( CreateDerectore(), Delete(), Exist(), GetCurrentDirectory() GetFile(), Move())

                var files = Directory.GetFiles(@"c:\project\file.pdf", "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Console.Write(files);
                }

                var derectories = Directory.GetDirectories(@"C:\project\file.pdf", "*.*", SearchOption.AllDirectories);
                foreach (var directory in derectories) {
                    Console.Write(directory);
                }

                Directory.Exists("...");


                // DerectoryInfo - instance method 


                var directory = new DirectoryInfo("...");
                directory.GetFiles();
                directory.GetDirectories();


                // Path  - (GetDorectoryName(), GetFileNamer(), GetExistensions(), GetTemoPath() )

                 var dotIndex = path.IndexOf('.');
                 var extensions = path.Substring(dotIndex);

                Path.GetExtension(path);


                path.GetExtansios(path);









            }
        }
    }
}
