namespace DesignPattern.MVCPattern 
{ 
    public class Program
    {
        public static void Main(string[] args)
        {

            // 从数据库获取学生记录
            Student model = retrieveStudentFromDatabase();

            // 创建一个视图：把学生详细信息输出到控制台
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);
            controller.updateView();    // View

            // Model是被观察的对象，View是观察者。
            // Model层一旦发生变化，View层即被通知更新
            // 更新模型数据
            {
                controller.setStudentName("John");  // Model
                controller.updateView();    // View
            }
        }

        private static Student retrieveStudentFromDatabase()
        {
            Student student = new Student();
            student.setName("Robert");
            student.setRollNo("10");
            return student;
        }
    }
}