using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Runner
    {
        static void Main(string[] args)
        {

            Employee.companyName = "Siemens";

            Employee emp1 = new Employee(101);
            Employee emp2 = new Employee(102,"Jack");
            Employee emp3 = new Employee("bala",103);

            //Employee emp4= Employee.GetEmployeeInstance();
            //emp4.DisplayEmployeeRecord();

            //load emp1 (101, Saul, 9000, A, Siemens)
            emp1.empId = -101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "A";

            //load emp2 (102, Kim, 5000, B, Siemens)
            emp2.empId = 102;
            emp2.empName = "Kim";
            emp2.empSalary = 5000;
            emp2.empPerformance = "B";


            emp2.DisplayEmployeeRecord();
            emp1.DisplayEmployeeRecord();
            emp3.DisplayEmployeeRecord();
            
            Employee.PrintEmployeeRecord(emp2);
            Employee.PrintEmployeeRecord(emp1);


            //Employee emp5= Employee.GetEmployeeInstance();
            //emp5.empId = 404;
            //emp5.empName = "king";
            //emp5.DisplayEmployeeRecord();

            Employee.PrintEmployeeRecord(emp3);

            Employee emp4= Employee.GetEmployeeInstance();
        }

    }
}
