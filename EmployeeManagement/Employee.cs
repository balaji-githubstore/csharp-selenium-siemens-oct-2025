using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
  
    public class Employee 
    {
        public int empId;
        public string empName;
        public double empSalary;
        public string empPerformance;
        public static string companyName;

        public Employee()
        {

        }
        public Employee(int a)
        {
            empId = a;
        }
        public Employee(int empId,string empName)
        {
            this.empId = empId;
            this.empName = empName;
        }
        public Employee(string empName,int empId):this(empId,empName) 
        {
            
        }

        public Employee(double a)
        {
            Console.WriteLine(a);
        }

        public void DisplayEmployeeRecord()
        {
            //local variable will be given higher prefrence when on conflict with non-static variable 
            int empId = 44444;
            Console.WriteLine("Printing local variable "+empId);
            Console.WriteLine("Printing instance/non-static variable " + this.empId);
            Console.WriteLine(this.empId);
            Console.WriteLine(this.empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(empPerformance);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("---------------------------");
        }

        //not efficient
        public static void PrintEmployeeRecord(Employee x)
        {
            Console.WriteLine(x.empId);
            Console.WriteLine(x.empName);
            Console.WriteLine(x.empSalary);
            Console.WriteLine(x.empPerformance);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("---------------------------");
        }


        public static Employee GetEmployeeInstance()
        {
            Employee e = new Employee();
            return e;
        }
    }
}
