using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {

        private int empID;
        public string empName;
        public double empSalary;
        public string empPerformance;
        public static string CompanyName;



        public int EmpId
            {
            get 
            { return empID; 
            }
            set
            {
                if (value > 100)
                {
                    empID = value;
                }
                else
                {
                    Console.WriteLine("Value is not valid , Please enter the value above 100");
                }
            }
        }

        public void DisplayEmployeeDetails()
        {

            Console.WriteLine("Employee ID:" + empID);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("Employee Performance:" + empPerformance);
            Console.WriteLine("Company Name:" + Employee.CompanyName);
            Console.WriteLine("_______________________________________________________");
        }
        public void AllocateBonus()
        {

            if (empPerformance != null)
            {

                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;
                    Console.WriteLine("The salary after bonus:" + empSalary);
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                    Console.WriteLine("The salary after bonus:" + empSalary);
                }
                if (empPerformance.Equals("C"))
                {
                    empSalary = empSalary + 100;
                    Console.WriteLine("The salary after bonus:" + empSalary);

                }
            }
        }



        /*public static Employee getinstance()
        {
            Employee emp = new Employee();
            return emp;*/
        }

    }

