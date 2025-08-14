using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_C_
{
    #region Employee struct
    //internal struct Employee
    //{
    //    private int EmpId;
    //    private string Name;
    //    private decimal Salary;

    //    public string GetName()
    //    {
    //        return Name;
    //    }

    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }

    //    public Employee(int empId, string name, decimal salary)
    //    {
    //        EmpId = empId;
    //        Name = name;
    //        Salary = salary;
    //    }
    //} 
    #endregion


    #region Employee class
    internal class Employee
    {
        public string Name;
        public decimal Salary;

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    #endregion
}
