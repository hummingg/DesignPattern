namespace DesignPattern.StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car tesla = new Car() {Name = "特斯拉 Model S"};

            // 停止的车不可加速、减速
            tesla.SpeedUp();
            tesla.SpeedDown();

            tesla.Run();
            tesla.SpeedUp();
            tesla.SpeedDown();
            tesla.Stop();
        }
    }
}
