using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingOnDataType
{
    public class PlayWithStringBuilder
    {
        // Initialize String Builder
        StringBuilder myString = new StringBuilder("Hello World!");
        public void Print()
        {
            Console.WriteLine(myString);
        }

        public void MemoryAllocationInformation(StringBuilder allocatedString)
        {
            string myString = allocatedString.ToString();
            int byteCount = Encoding.UTF8.GetByteCount(myString);

            Console.WriteLine($"String: \"{myString}\"");
            Console.WriteLine($"Memory Allocation (bytes): {byteCount}");
        }

        public unsafe void MemoryAddress()
        {
            string r = "Hello, World!";
            StringBuilder stringBuilder = new StringBuilder("Hello, World!");

            fixed (char* charPtr = r)
            {
                // 'charPtr' now contains the memory address of the string 'r'
                Console.WriteLine($"Memory Address of \"{r}\": 0x{(long)charPtr:X}");
            }

            fixed (char* charStringBuilder = stringBuilder.ToString())
            {
                Console.WriteLine($"Memory Address of String Builder : 0x{(long)charStringBuilder:X}");
            }
        }

    }
}
