using System;

namespace Task_6_C_
{
    internal class Program
    {
        #region problem 5
        //static void ModifyPoint(Point p)
        //{
        //    p.x = 100;
        //    p.y = 200;
        //    Console.WriteLine($"Inside ModifyPoint: ({p.x}, {p.y})");
        //}

        //static void ModifyEmployee(Employee emp)
        //{
        //    emp.Name = "mohamed";
        //    emp.Salary = 9999;
        //    Console.WriteLine($"Inside ModifyEmployee: {emp.Name}, {emp.Salary}");
        //}

        #endregion
        static void Main(string[] args)
        {
            #region problem 1
            //Point p1;
            //p1 = new Point(2, 3);
            //Console.WriteLine(p1);
            #endregion

            #region problem 2
            //TypeA t = new TypeA();
            //Console.WriteLine(t.H);//public
            //Console.WriteLine(t.F);//private
            //Console.WriteLine(t.G);//internal
            #endregion


            #region problem 3
            //Employee employee = new Employee();
            //employee.SetName("mohamedsabryoda");
            //Console.WriteLine(employee.GetName());
            #endregion


            #region problem 4
            //Point p1 = new Point(1);
            //Console.WriteLine(p1);
            //Point p2 = new Point(2,6);
            //Console.WriteLine(p2);
            #endregion


            #region problem 5
            //Point p1 = new Point(5, 10);
            //Console.WriteLine($"Before ModifyPoint: ({p1.x}, {p1.y})");
            //ModifyPoint(p1);
            //Console.WriteLine($"After ModifyPoint: ({p1.x}, {p1.y})"); // unchanged

            //Console.WriteLine();

            //// Class: Reference type
            //Employee emp1 = new Employee("Ali", 5000);
            //Console.WriteLine($"Before ModifyEmployee: {emp1.Name}, {emp1.Salary}");
            //ModifyEmployee(emp1);
            //Console.WriteLine($"After ModifyEmployee: {emp1.Name}, {emp1.Salary}"); // changed
            #endregion
        }
    }
}
