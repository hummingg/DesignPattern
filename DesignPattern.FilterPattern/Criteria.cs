namespace DesignPattern.FilterPattern
{
    /// <summary>
    /// 步骤 2 为标准（Criteria）创建一个接口。
    /// </summary>
    public interface Criteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }

    /// <summary>
    /// 步骤 3 创建实现了 Criteria 接口的实体类。
    /// </summary>
    public class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.ToUpper().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }

    public class CriteriaFemale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.ToUpper().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }

    public class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.MaritalStatus.ToUpper().Equals("SINGLE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }


    public class AndCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = criteria.MeetCriteria(persons);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }

    public class OrCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public OrCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.MeetCriteria(persons);

            foreach (Person person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }

}
