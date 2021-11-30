using System;

namespace DesignPattern
{
    /// <summary>
    /// 环境：VS2022+.Net6.0
    /// 
    /// 
    /// 场景出发--解决问题--总结沉淀--推广应用
    /// 
    /// 
    /// 适配器和代理  装饰器 很像
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("***************结构型设计模式**************");
                //{
                //    Console.WriteLine("********适配器模式********");
                //    DesignPattern.AdapterPattern.Program.Show();
                //}
                //{
                //    Console.WriteLine("********代理模式********");
                //    DesignPattern.ProxyPattern.Program.Show();
                //}
                //{
                //    Console.WriteLine("********装饰器模式********");
                //    DesignPattern.DecoratorPattern.Program.Show();
                //}
                //Console.WriteLine("***************行为型设计模式**************");
                //{
                //    Console.WriteLine("********责任链模式********");
                //    DesignPattern.ResponsibilityChainPattern.Program.Show();
                //}
                //{
                //    Console.WriteLine("********模板方法********");
                //    DesignPattern.TemplateMethodPattern.Program.Show();
                //}
                {
                    Console.WriteLine("********观察者********");
                    DesignPattern.ObserverPattern.Program.Show();
                }

                //Console.WriteLine("***************创建型设计模式**************");
                //{
                //    Console.WriteLine("********单例&原型模式********");
                //    SingletonPattern.Program.Show();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
