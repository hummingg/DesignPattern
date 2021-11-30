using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 安卓数据线，adaptee角色
    /// </summary>
    public class AndroidLine
    {
        public void AndroidCharge()
        {
            Console.WriteLine("安卓数据线充电....");
        }
    }

    /// <summary>
    /// 苹果手机充电接口，目标接口
    /// </summary>
    public interface IAppleCharge
    {
        void AppleCharge();
    }

    /// <summary>
    /// 苹果适配器 适配器角色
    /// </summary>
    public class AppleAdapter : IAppleCharge
    {
        AndroidLine androidLine = new AndroidLine();//适配器内部包含一个Adaptee对象
        public void AppleCharge()
        {
            androidLine.AndroidCharge();//客户端调用时，表面上是用的是ApplyChange方法,本质还是用的AndroidCharge方法
        }
    }
}
