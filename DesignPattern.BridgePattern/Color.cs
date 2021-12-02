namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 颜色接口
    /// </summary>
    public interface IColor
    {
        void Paint(string shape);
    }
    /// <summary>
    /// 蓝色
    /// </summary>
    public class Blue : IColor
    {
        public void Paint(string shape)
        {
            Console.WriteLine($"蓝色的{shape}");   // 把字符串 拼接 起来了，这就是桥接？
        }
    }
    /// <summary>
    /// 黄色
    /// </summary>
    public class Yellow : IColor
    {
        public void Paint(string shape)
        {
            Console.WriteLine($"黄色的{shape}");
        }
    }
    /// <summary>
    /// 红色
    /// </summary>
    public class Red : IColor
    {
        public void Paint(string shape)
        {
            Console.WriteLine($"红色的{shape}");
        }
    }
}
