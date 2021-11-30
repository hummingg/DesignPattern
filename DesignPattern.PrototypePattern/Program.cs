// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// https://www.cnblogs.com/wyy1234/p/9992309.html
namespace DesignPattern.PrototypePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //创建一个person实例
            Person person1 = new Person()
            {
                Name = "jack",
                Age = 20,
                Address = new Address { Province = "山东", City = "青岛" }
            };
            //一个克隆人，通过clone方法替代了new方法
            Person clonePerson = (Person)person1.Clone();

            ////这里使用直接赋值，而不是clone
            //Person clonePerson = person1;

            clonePerson.Name = "tom";   // Name 和 Age 是值类型，不会影响 person1
            clonePerson.Age = 22;
            clonePerson.Address.Province = "浙江";    // Address 是引用类型，会同时改变 person1
            clonePerson.Address.City = "杭州";

            Console.WriteLine($"person1的name:{person1.Name},年龄:{person1.Age}," +
                              $"省份:{person1.Address.Province},城市:{person1.Address.City}");
            Console.WriteLine($"克隆人的name:{clonePerson.Name},年龄:{clonePerson.Age}," +
                              $"省份:{clonePerson.Address.Province},城市:{clonePerson.Address.City}");
        }
    }
}