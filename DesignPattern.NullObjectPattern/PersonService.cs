namespace DesignPattern.NullObjectPattern
{
    public class PersonService
    {
        /// <summary>
        /// 获取用户信息方法
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>用户信息对象实体</returns>
        public Human GetPersonById(int id)
        {
            Human human = null;
            if (id == 1)
            {
                human = new Person
                {
                    Id = 111,
                    Name = "小明"
                };
            }
            else
            {
                human = new NullPerson();
            }
            return human;
        }
    }
}
