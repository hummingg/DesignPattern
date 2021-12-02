namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 享元：共享资源更经济
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();

            //小头爸爸开蓝色的车
            Driver d1 = new Driver("小头爸爸");
            Car c1 = carFactory.GetCar("蓝色");
            //c1.Use(d1); // 不合理？
            d1.Drive(c1);   // 更合理？

            //扁头妈妈开蓝色的车
            Driver d2 = new Driver("扁头妈妈");
            Car c2 = carFactory.GetCar("蓝色");
            //c2.Use(d2);
            d2.Drive(c2);

            if (c1.Equals(c2))
            {
                Console.WriteLine("小头爸爸和扁头妈妈开的是同一辆车");  // 享元模式，池化资源
            }

            d2.Drive(carFactory.GetCar("红色"));

            //车库没有白色的车，就new一辆白色的车
            Driver d3 = new Driver("大头儿子");
            Car c3 = carFactory.GetCar("白色");
            //c3.Use(d3);
            d3.Drive(c3);

            //车库没有白色的车，就new一辆白色的车
            Car c4 = carFactory.GetCar("白色");
            if (c4.Equals(c3))
            {
                d3.Drive(c4);
                Console.WriteLine("大头儿子2次开的是同一辆车");  // 享元模式，池化资源
            }
            else
            {
                Console.WriteLine("大头儿子只想开上次那辆车");
            }
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10041658.html