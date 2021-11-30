namespace DesignPattern.NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("空对象模式******************************");
                var service = new PersonService();
                var person = service.GetPersonById(2);
                Console.WriteLine("用户的Id为：{1}, 名字为：{0}", person.Name, person.Id);
                person.Study();
            }
        }
    }
}