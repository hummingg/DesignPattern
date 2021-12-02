namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 车库，出租车辆
    /// </summary>
    public class CarFactory
    {
        private Dictionary<string, Car> carPool = new();
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
                Console.WriteLine($"车库里没有{key}的车，买一辆");
                carPool.Add(key, new RealCar(key));
            }
            else
            {
                Console.WriteLine($"车库里有{key}的车");
            }
            return carPool[key];
        }
    }
}
