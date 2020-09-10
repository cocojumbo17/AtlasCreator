using System;

namespace ImageUnpacker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect parameters:");
                Console.WriteLine("ImageUnpacker.exe <png-filename to unpack> <gmm-file with slices>");
            }
            Unpacker unpacker = new Unpacker(args[0], args[1]);
            unpacker.Unpack();
        }
    }
}
