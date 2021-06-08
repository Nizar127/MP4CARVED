using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MP4Carver
{
    class CarveFile
    {
        //[DllImport("project.c", CallingConvention = CallingConvention.Cdecl)]

        [DllImport("libtest.so", EntryPoint = "carve")]

        static extern void carve(string message);

        public static void Main(string[] args)
        {

            carve("Hello World C# => C++");
        }
    }
}
