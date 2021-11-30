namespace DesignPattern.FilterPattern
{
    /// <summary>
    /// 步骤 1 创建一个类，在该类上应用标准。
    /// </summary>
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
        }

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
    }
}
