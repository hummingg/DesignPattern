using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine($"蓝色的{shape}");
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
