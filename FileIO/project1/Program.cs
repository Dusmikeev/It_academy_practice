using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            void DirectoryInfo()
            {

                DirectoryInfo directory = new DirectoryInfo(@"C:\Windows");
                Console.WriteLine(directory.FullName);
                Console.WriteLine(directory.CreationTime);

                FileInfo[] fileInfos = directory.GetFiles();

                foreach (var item in fileInfos)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.CreationTime);
                    Console.WriteLine(item.Length);
                }
            }

            void CopyPaste()
            {
                Directory.CreateDirectory(@"D:\MyDir");
                DirectoryInfo directory = new DirectoryInfo(@"C:\Windows");

                var files = directory.GetFiles();
                var firstFile = files[0];
                firstFile.CopyTo(@"D:\MyDir\FileName.txt");
            }

            DirectoryInfo();
            CopyPaste();
            
            //FileInfo file = new FileInfo(@"D:\MeRead.txt");
            //FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //byte[] guys = Encoding.Default.GetBytes("Hello, guys!");
            //fs.Write(guys, 0, guys.Length);
            //fs.Close();

            //fs = file.Open(FileMode.Open);
            //byte[] text = new byte[fs.Length];
            //fs.Read(text, 0, text.Length);
            //fs.Close();

            
            Console.Read();
            
        }
    }
}
