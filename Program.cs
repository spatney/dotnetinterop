using System.Runtime.InteropServices;
using System.Security;
using System;

namespace dotnetinterop
{
    class Program
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport(@"./cpp/lib/libsum")]
        public static extern int Sum(int a, int b);

        static void Main(string[] args)
        {
            var sum = Sum(Int32.Parse(args[0]), Int32.Parse(args[1]));

            Console.WriteLine($"SUM: {sum}");
        }
    }
}
