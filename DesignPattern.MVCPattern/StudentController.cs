namespace DesignPattern.MVCPattern
{
    // View层，单独实现了组合模式
    // Model层和View层，实现了观察者模式
    // View层和Controller层，实现了策咯模式
    public class StudentController
    {
        private Student model;

        // Controller是View的一个策略，Controller 对于 View 是可替换的。
        // View 和Controller 的关系是一对多。
        // 在实际的开发场景中，也经常会碰到一个 View 被多个 Controller 引用。
        // 这就是策咯模式的一种体现，只是不那么直观而已。
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setStudentName(String name)
        {
            model.setName(name);
        }

        public String getStudentName()
        {
            return model.getName();
        }

        public void setStudentRollNo(String rollNo)
        {
            model.setRollNo(rollNo);
        }

        public String getStudentRollNo()
        {
            return model.getRollNo();
        }

        public void updateView()
        {
            view.printStudentDetails(model.getName(), model.getRollNo());
        }
    }
}
