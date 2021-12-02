namespace DesignPattern.FlyweightPattern
{
    ///抽象车类
    public abstract class Car
    {
        //颜色
        public string Color { get; set; }
        public Car(string color)
        {
            this.Color = color;
        }
        //开车
        public abstract void Use(Driver d);
    }

    /// <summary>
    /// 具体的车类
    /// </summary>
    public class RealCar : Car
    {
        public RealCar(string color) : base(color)
        {
        }
        //开车
        public override void Use(Driver d)
        {
            Console.WriteLine($"{d.Name}开{this.Color}的车");
        }
    }
}
