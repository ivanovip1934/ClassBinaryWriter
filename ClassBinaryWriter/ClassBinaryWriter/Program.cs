using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassBinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            string pathToBinaryData = "c:\\programs\\binarydata.dat";

            using (FileStream output = File.Create(pathToBinaryData))
            {
                using (BinaryWriter writer = new BinaryWriter(output))
                {
                    writer.Write(intValue);
                    writer.Write(stringValue);
                    writer.Write(byteArray);
                    writer.Write(floatValue);
                    writer.Write(charValue);
                }
            }

            byte[] dataWritten = File.ReadAllBytes(pathToBinaryData);
            foreach (byte b in dataWritten)            
                Console.Write("{0:x2} ", b);
            Console.WriteLine(" - {0} bytes", dataWritten.Length);

            Console.ReadKey();          


        }
    }
}
