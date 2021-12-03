namespace DesignPattern.ResponsibilityChainPattern
{
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
            bool isLast = NextApproval == null;
            if (isLast)
            {
                Console.WriteLine("最后一关");
            }
            if (request.Salary <= 7000)
            {
                Console.WriteLine($"本HR同意{request.Name}的{request.Salary}薪水！");
            }
            if (!isLast)
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
            bool isLast = NextApproval == null;
            if (isLast)
            {
                Console.WriteLine("最后一关");
            }
            if (request.Salary <= 12000)
            {
                //Console.WriteLine("本技术经理同意您的薪水！");
                Console.WriteLine($"本技术经理同意{request.Name}的{request.Salary}薪水！");
            }
            if (!isLast)
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
            bool isLast = NextApproval == null;
            if (isLast)
            {
                Console.WriteLine("最后一关");
            }
            Console.WriteLine($"本总经理同意{request.Name}的{request.Salary}薪水！");
            if (!isLast)
            {
                NextApproval.ProcessRequest(request);
            }
        }
    }
}
