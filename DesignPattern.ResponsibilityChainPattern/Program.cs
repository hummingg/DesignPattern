namespace DesignPattern.ResponsibilityChainPattern
{
    /// <summary>
    /// 现有一个需求，如下：
    /// 公司面试，HR确定求职者薪资，若薪资在7000元以下，则由HR决定；
    /// 若薪资在7000-12000元，则由技术经理决定；
    /// 若薪资在12000元以上，则需要由总经理决定。
    /// 现在定义三名求职者，Tom、David、Marin，索求薪资分别为5500元、8000元、13000元。
    /// </summary>

    ///求职信息
    public class JobSearchInformation
    {
        //求职者姓名
        public string Name;
        //索求薪资
        public double Salary;
        //写个构造方法
        public JobSearchInformation(string Name, double Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }
    }

    //抽象处理者角色（Handler）：定义出一个处理请求的接口。这个接口通常由接口或抽象类来实现。
    public abstract class Approval
    {
        //下一个权限人
        public Approval NextApproval { get; set; }
        //审批方法
        public abstract void ProcessRequest(JobSearchInformation request);
    }

    //具体处理者角色（ConcreteHandler）：
    //具体处理者接受到请求后，可以选择将该请求处理掉，或者将请求传给下一个处理者。
    //因此，每个具体处理者需要保存下一个处理者的引用，以便把请求传递下去。
    //HR
    public class HumanResources : Approval
    {
        public override void ProcessRequest(JobSearchInformation request)
        {
            if (NextApproval == null)
            {
                Console.WriteLine("最后一关");
            }
            if (request.Salary <= 7000)
            {
                Console.WriteLine($"本HR同意{request.Name}的{request.Salary}薪水！");
                NextApproval.ProcessRequest(request);
            }
            else
            {
                NextApproval.ProcessRequest(request);
            }
        }
    }
    //技术经理
    public class TechnologyManager : Approval
    {
        public override void ProcessRequest(JobSearchInformation request)
        {
            if (NextApproval == null)
            {
                Console.WriteLine("最后一关");
            }
            if (request.Salary <= 12000)
            {
                //Console.WriteLine("本技术经理同意您的薪水！");
                Console.WriteLine($"本技术经理同意{request.Name}的{request.Salary}薪水！");
                NextApproval.ProcessRequest(request);
            }
            else
            {
                NextApproval.ProcessRequest(request);
            }
        }
    }
    //总经理
    public class GeneralManager : Approval
    {
        public override void ProcessRequest(JobSearchInformation request)
        {
            //Console.WriteLine("本总经理同意您的薪水！");
            if(NextApproval == null)
            {
                Console.WriteLine("最后一关");
            }
            Console.WriteLine($"本总经理同意{request.Name}的{request.Salary}薪水！");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //模拟三位求职者
            JobSearchInformation JobSeeker1 = new JobSearchInformation("Tom", 5500);
            JobSearchInformation JobSeeker2 = new JobSearchInformation("David", 8000);
            JobSearchInformation JobSeeker3 = new JobSearchInformation("Marin", 13000);
            //实例化三个权限
            Approval humanResources = new HumanResources();
            Approval technologyManager = new TechnologyManager();
            Approval generalManager = new GeneralManager();
            //设置权限关系
            humanResources.NextApproval = technologyManager;
            technologyManager.NextApproval = generalManager;
            generalManager.NextApproval = null;
            //处理求职者薪资问题
            humanResources.ProcessRequest(JobSeeker1);
            humanResources.ProcessRequest(JobSeeker2);
            humanResources.ProcessRequest(JobSeeker3);
        }
    }
}
