
using System;

namespace Lab03_OOPAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            Bai01.Demo.Run();
            Bai02.Demo.Run();
            Bai03.Demo.Run();
            Bai04.Demo.Run();
            Bai05.Demo.Run();
            Bai06.Demo.Run();
            Bai07.Demo.Run();
            Bai08.Demo.Run();
            Bai09.Demo.Run();
            Bai10.Demo.Run();

            Console.WriteLine("\nDa chay xong ca 10 bai.");
            Console.ReadKey();
        }
    }
}
