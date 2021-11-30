namespace DesignPattern.PrototypePattern
{
    /// <summary>
    /// Person
    /// </summary>
    public class Person : PersonPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // 引用类型，浅拷贝
        public Address Address { get; set; }

        public override object Clone()
        {
            //MemberwiseClone方法实现浅拷贝
            return this.MemberwiseClone();
        }
    }

    /// <summary>
    /// 住址
    /// </summary>
    public class Address
    {
        public string Province { get; set; }
        public string City { get; set; }
    }
}
