using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_ModelAnswer
{
    class Employee
    {
        protected int employeeId;
        protected string fullName;
        protected float salary;
        protected bool taxDeducted;

        public Employee(int employeeId, string fullName, float salary, bool taxDeducted)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.salary = salary;
            this.taxDeducted = taxDeducted;
        }

        public Employee(int employeeId, string fullName, float salary)
        {
            this.employeeId = employeeId;
            this.fullName = fullName;
            this.salary = salary;
            this.taxDeducted = true;
        }

        public float getNetSalary()
        {
            if (taxDeducted)
            {
                return salary * 0.8f;
            }

            return salary;
        }

        public void printInformation()
        {
            Console.WriteLine("" + employeeId + ", " + fullName + " earns " + getNetSalary() + " per month.");
        }
    }
}
