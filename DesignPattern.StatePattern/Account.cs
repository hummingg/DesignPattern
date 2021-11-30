namespace DesignPattern.StatePattern
{
    public class Account
    {
        public State State { get; set; }
        public string Owner { get; set; }
        public Account(string owner)
        {
            this.Owner = owner;
            this.State = new SilverState(0.0, this);
        }

        public double Balance { get { return State.Balance; } } // 余额
        // 存钱
        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("存款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        // 取钱
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("取款金额为 {0:C}——", amount);
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        // 获得利息
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine("账户余额为 =:{0:C}", this.Balance);
            Console.WriteLine("账户状态为: {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}