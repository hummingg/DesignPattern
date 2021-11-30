namespace DesignPattern.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 个人所得税方式
            InterestOperation operation = new InterestOperation(new PersonalTaxStrategy());
            Console.WriteLine("个人支付的税为：{0}", operation.GetTax(5000.00));

            // 企业所得税
            operation = new InterestOperation(new EnterpriseTaxStrategy());
            Console.WriteLine("企业支付的税为：{0}", operation.GetTax(50000.00));
        }
    }
}