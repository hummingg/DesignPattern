namespace DesignPattern.BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            IColor blue = new Blue();

            shape = new Circle();
            shape.SetColor(blue);//设置颜色
            shape.Draw();//画图

            shape = new Triangle();
            shape.SetColor(blue);
            shape.Draw();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10016051.html