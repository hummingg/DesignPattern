namespace DesignPattern.ResponsibilityChainPattern
{
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
}
