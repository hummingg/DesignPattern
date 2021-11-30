namespace DesignPattern.StrategyPattern
{
    // 所得税计算策略
    public interface ITaxStrategy
    {
        double CalculateTax(double income);
    }

    // 个人所得税
    public class PersonalTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }

    // 企业所得税
    public class EnterpriseTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }
}