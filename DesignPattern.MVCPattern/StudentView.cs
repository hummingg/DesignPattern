namespace DesignPattern.MVCPattern
{
    //除网页以外的其他用户界面程序，如WPF、Android、Asp.net等等都是使用树状结构来组织界面控件对象的，
    //因为组合模式就是从界面设计的通用解决方案总提炼出来的。
    public class StudentView
    {
        public void printStudentDetails(String studentName, String studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
