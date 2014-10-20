using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipUtil
{
    class Program
    {
        private static bool create;
        private static string name;
        private static string target;

        static void Main(string[] args)
        {
            if (args[1] == "true")
                create = true;
            else
                create = false;

            name = args[2];
            target = args[3];


            if (create)
                ZipFile.CreateFromDirectory(target, name, CompressionLevel.Optimal, false);
            else
                ZipFile.ExtractToDirectory(name, target);
        }
    }
}
