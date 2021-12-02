namespace DesignPattern.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //监工1派遣技术好的建造者盖房子
            GoodBuilder goodBuilder = new GoodBuilder();
            Director director1 = new Director(goodBuilder);
            director1.Construct();
            string house1 = goodBuilder.GetHouse();
            Console.WriteLine(house1);

            //监工2派遣技术差的建造者盖房子
            BadBuilder badBuilder = new BadBuilder();
            Director director2 = new Director(badBuilder);
            director2.Construct();
            string house2 = badBuilder.GetHouse();
            Console.WriteLine(house2);
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/9992831.html