using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FlyweightPattern
{
    ///抽象车类
    public abstract class Car
    {
        //开车
        public abstract void Use(Driver d);
    }

    /// <summary>
    /// 具体的车类
    /// </summary>
    public class RealCar : Car
    {
        //颜色
        public string Color { get; set; }
        public RealCar(string color)
        {
            this.Color = color;
        }
        //开车
        public override void Use(Driver d)
        {
            Console.WriteLine($"{d.Name}开{this.Color}的车");
        }
    }

    /// <summary>
    /// 车库
    /// </summary>
    public class CarFactory
    {
        private Dictionary<string, Car> carPool = new Dictionary<string, Car>();
        //初始的时候，只有红色和绿色两辆汽车
        public CarFactory()
        {
            carPool.Add("红色", new RealCar("红色"));
            carPool.Add("绿色", new RealCar("蓝色"));
        }
        //获取汽车
        public Car GetCar(string key)
        {
            //如果车库有就用车库里的车，车库没有就买一个（new一个）
            if (!carPool.ContainsKey(key))
            {
                carPool.Add(key, new RealCar(key));
            }
            return carPool[key];
        }
    }

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
    }
}
