using System;
using System.Collections.Generic;
using System.Text;

// https://www.cnblogs.com/wyy1234/p/10029450.html
namespace DesignPattern.CompositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Show();
        }

        public static void Show()
        {
            Component DepartA = new Depart("A总公司");
            Component DepartAX = new Depart("AX部门");
            Component DepartAY = new Depart("AY部门");
            Component DepartAX1 = new Depart("AX1子部门");
            Component DepartAX2 = new Depart("AX2子部门");
            Component Ae1 = new Employee("公司直属员工1");
            Component AXe1 = new Employee("AX部门员工1");
            Component AX1e1 = new Employee("AX1部门员工1");
            Component AX1e2 = new Employee("AX1部门员工2");
            Component AYe1 = new Employee("AY部门员工1");
            Component AYe2 = new Employee("AY部门员工2");
            DepartA.Add(Ae1);
            DepartA.Add(DepartAX);
            DepartA.Add(DepartAY);
            DepartAX.Add(AXe1);
            DepartAX.Add(DepartAX1);
            DepartAX.Add(DepartAX2);
            DepartAX1.Add(AX1e1);
            DepartAX1.Add(AX1e2);
            DepartAY.Add(AYe1);
            DepartAY.Add(AYe2);
            //遍历总公司
            DepartA.Display(1);
            Console.ReadKey();
        }
    }
}
