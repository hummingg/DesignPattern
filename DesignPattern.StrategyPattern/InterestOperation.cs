namespace DesignPattern.StrategyPattern
{
    public class InterestOperation
    {
        private ITaxStrategy m_strategy;
        public InterestOperation(ITaxStrategy strategy)
        {
            this.m_strategy = strategy;
        }

        public double GetTax(double income)
        {
            return m_strategy.CalculateTax(income);
        }
    }
}
