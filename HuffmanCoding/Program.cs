using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte[] fileBytes = System.IO.File.ReadAllBytes("C:\\Users\\bruger\\Pictures\\5f2342b8524f36b340f397d2598797a4.jpg");
            for (int i = 0; i < 10; i++)
            {
                int byteNumber = (int)fileBytes[i];
                Console.WriteLine(byteNumber);
            }

            Console.ReadKey();
            */

            /*
            ByteData[] fileStat = new ByteData[256];
            for (int i = 0; i < 256; i++)
            {
                fileStat[i] = new ByteData() { Bytevalue = i, Amount = 0 };
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes("C:\\Users\\bruger\\Pictures\\5f2342b8524f36b340f397d2598797a4.jpg");
            foreach (byte b in fileBytes)
            {
                int byteNumber = b;
                fileStat[byteNumber].Amount++;
            }
            var fileStatOrderd = fileStat.OrderByDescending(p => p.Amount).ToArray();

            Console.WriteLine("File size: " + fileBytes.Count());
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + " => " + fileStatOrderd[i].Bytevalue +
                " : " + fileStatOrderd[i].Amount);
            }

            Console.ReadKey();
            */

            List<byte> huffmanData = new List<byte>();

            huffmanData.Add(0);
            huffmanData.Add(0);
            huffmanData.Add(1);
            huffmanData.Add(1);
            huffmanData.Add(1);
            huffmanData.Add(0);
            huffmanData.Add(0);
            huffmanData.Add(0);

            for (int i = 0; i < huffmanData.Count; i += 8)
            {
                byte numberByte = (byte)(huffmanData[i] + huffmanData[i + 1] * 2 +
                    huffmanData[i + 2] * 4 + huffmanData[i + 3] * 8 +
                    huffmanData[i + 4] * 16 + huffmanData[i + 5] * 32 +
                    huffmanData[i + 6] * 64 + huffmanData[i + 7] * 128);

                Console.WriteLine(numberByte);
            }

            byte[] fileData = new byte[huffmanData.Count / 8];

            for (int i = 0; i < huffmanData.Count; i += 8)
            {
                fileData[i / 8] = (byte)(huffmanData[i] + huffmanData[i + 1] * 2 +
                     huffmanData[i + 2] * 4 + huffmanData[i + 3] * 8 +
                     huffmanData[i + 4] * 16 + huffmanData[i + 5] * 32 +
                     huffmanData[i + 6] * 64 + huffmanData[i + 7] * 128);
            }

            System.IO.File.WriteAllBytes("C:\\Users\\bruger\\Dropbox\\EAL - Datamatiker\\4. semester\\Advanced Programming\\adp.data", fileData);
        }
    }
}
