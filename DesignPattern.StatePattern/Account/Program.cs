namespace DesignPattern.StatePattern.Account
{
    class Program
    {
        static void Show(string[] args)
        {
            // 开一个新的账户
            Account account = new Account("Learning Hard");

            // 进行交易
            // 存钱
            account.Deposit(1000.0);
            account.Deposit(200.0);
            account.Deposit(600.0);

            // 付利息
            account.PayInterest();

            // 取钱
            account.Withdraw(1990.00);
            account.Withdraw(500.00);
        }
    }
}

// https://www.cnblogs.com/zhili/p/StatePattern.html