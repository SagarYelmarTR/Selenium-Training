using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {

        public static void Main(string[] args)
        {
            Employee.CompanyName = "TR";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.EmpId = -101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "B";

            emp2.EmpId = 102;
            emp2.empName = "peter";
            emp2.empSalary = 7000;
            emp2.empPerformance = "A";

            emp3.EmpId = 103;
            emp3.empName = "Kim";
            emp3.empSalary = 8000;
            emp3.empPerformance = "C";

            /*Console.WriteLine(emp1.empID);
            Console.WriteLine(emp2.empID);
            Console.WriteLine(emp3.empID);*/

            //Console.WriteLine(emp2.empID);


            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();

            emp1.AllocateBonus();
            emp2.AllocateBonus();
            emp3.AllocateBonus();


        }




    }
}
