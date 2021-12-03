namespace DesignPattern.ResponsibilityChainPattern
{
    /// <summary>
    /// 现有一个需求，如下：
    /// 公司面试，HR确定求职者薪资，若薪资在7000元以下，则由HR决定；
    /// 若薪资在7000-12000元，则由技术经理决定；
    /// 若薪资在12000元以上，则需要由总经理决定。
    /// 现在定义三名求职者，Tom、David、Marin，索求薪资分别为5500元、8000元、13000元。
    /// </summary>
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
