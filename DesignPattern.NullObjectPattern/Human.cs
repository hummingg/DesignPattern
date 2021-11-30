namespace DesignPattern.NullObjectPattern
{
    public abstract class Human
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// 用户名字
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 学习
        /// </summary>
        public abstract void Study();

    }

    public class Person : Human
    {
        /// <summary>
        /// 实现方法的默认实现
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("{0}学习中……", Name);
        }
    }

    public class NullPerson : Human
    {

        public NullPerson()
        {
            Id = 0;
            Name = "未知";
        }

        /// <summary>
        /// 实现方法的默认实现
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("无法学习");
        }
    }
}
