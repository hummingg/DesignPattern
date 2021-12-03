namespace DesignPattern.MementoPattern
{
    // 备忘录
    public class ContactMemento
    {
        public List<ContactPerson> ContactPersonBack { get; set; }
        public ContactMemento(List<ContactPerson> persons)
        {
            ContactPersonBack = persons;
        }
    }
}
