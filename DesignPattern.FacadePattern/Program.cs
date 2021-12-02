namespace DesignPattern.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            //开机
            computer.Start();   // 隐藏CPU、Memory、Disk一系列操作
            Console.WriteLine();
            //关机
            computer.Shutdown();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10012964.html