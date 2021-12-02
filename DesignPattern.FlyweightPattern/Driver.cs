namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 司机类
    /// </summary>
    public class Driver
    {
        public string Name { get; set; }
        public Driver(string name)
        {
            this.Name = name;
        }
        public void Drive(Car car)
        {
            Console.WriteLine($"{this.Name}开{car.Color}的车");
        }
    }
}
