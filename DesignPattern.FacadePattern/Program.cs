// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// https://www.cnblogs.com/wyy1234/p/10012964.html
namespace DesignPattern.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            //开机
            computer.Start();
            Console.WriteLine();
            //关机
            computer.Shutdown();
            Console.ReadKey();
        }
    }
}