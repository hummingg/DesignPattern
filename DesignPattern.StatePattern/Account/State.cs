namespace DesignPattern.StatePattern.Account
{
    // 抽象状态类
    public abstract class State
    {
        public Account Account { get; set; }
        public double Balance { get; set; } // 余额
        public double Interest { get; set; } // 利率
        public double LowerLimit { get; set; } // 余额下限
        public double UpperLimit { get; set; } // 余额上限

        public State(State state)
        {
            Account = state.Account;
            Balance = state.Balance;
        }

        public State(double balance, Account account)
        {
            Account = account;
            Balance = balance;
        }

        // 存款
        public virtual void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck(); // 模板方法模式
        }
        // 取钱
        public virtual void Withdraw(double amount) 
        {
            Balance -= amount;
            StateChangeCheck();
        }
        // 获得的利息
        public virtual void PayInterest() 
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }

        protected abstract void StateChangeCheck();
    }

    // Red State意味着Account透支了
    public class RedState : State
    {
        public RedState(State state) : base(state)
        {
            //this.Balance = state.Balance;
            //this.Account = state.Account;
            Interest = 0.00;
            LowerLimit = -100.00;
            UpperLimit = 0.00;
        }

        //// 存款
        //public override void Deposit(double amount)
        //{
        //    Balance += amount;
        //    StateChangeCheck();
        //}

        // 取钱
        public override void Withdraw(double amount)
        {
            Console.WriteLine("没有钱可以取了！");
        }

        //public override void PayInterest()
        //{
        //    Balance += Interest * Balance;
        //    StateChangeCheck();
        //}

        // 自动改变账户状态
        protected override void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }

    // 初始状态
    // Silver State意味着没有利息得
    public class SilverState : State
    {
        public SilverState(State state)
           : this(state.Balance, state.Account)
       { 
       }

       public SilverState(double balance, Account account) : base(balance, account)
       {
           Interest = 0.00;
           LowerLimit = 0.00;
           UpperLimit = 1000.00;
       }

        //public override void Deposit(double amount)
        //{
        //    Balance += amount;
        //    StateChangeCheck();
        //}

        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //    StateChangeCheck();
        //}

        //public override void PayInterest()
        //{
        //    Balance += Interest * Balance;
        //    StateChangeCheck();
        //}

        protected override void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }

    // Gold State意味着有利息状态
    public class GoldState : State
    {
        public GoldState(State state) : base(state)
        {
            //this.Balance = state.Balance;
            //this.Account = state.Account;
            Interest = 0.05;
            LowerLimit = 1_000.00;
            UpperLimit = 1_000_000.00;
        }
        //// 存钱
        //public override void Deposit(double amount)
        //{
        //    Balance += amount;
        //    StateChangeCheck();
        //}
        // 取钱
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //    StateChangeCheck();
        //}
        //public override void PayInterest()
        //{
        //    Balance += Interest * Balance;
        //    StateChangeCheck();
        //}

        protected override void StateChangeCheck()
        {
            if (Balance < 0.0)
            {
                Account.State = new RedState(this);
            }
            else if (Balance < LowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}