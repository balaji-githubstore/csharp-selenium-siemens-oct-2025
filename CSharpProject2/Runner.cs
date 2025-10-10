using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject2
{
    class Employee

    {

        int empNo;

        Employee(int empNo)

        {

            this.empNo = empNo;

        }

        static void Main(string[] args)

        {

            Employee emp = new Employee(101);

            Console.WriteLine(emp.empNo);

        }

    }

    public class Runner
    {

        static void Main1(string[] args)
        {


            Calculator cal = new Calculator();

            cal.Add(10, 10);



        }
    }
}
