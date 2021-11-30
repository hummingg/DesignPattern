// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace DesignPattern.BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            IColor blue = new Blue();
            circle.SetColor(blue);//设置颜色
            circle.Draw();//画图

            Shape triangle = new Triangle();
            triangle.SetColor(blue);
            triangle.Draw();

            Console.ReadKey();
        }
    }
}