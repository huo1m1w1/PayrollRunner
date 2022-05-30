using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_ModelAnswer
{
    class WeeklyEmployee : Employee
    {
        public WeeklyEmployee(int employeeId, string fullName, float salary, bool taxDeducted) : 
            base (employeeId, fullName, salary, taxDeducted)

        {

        }

        public WeeklyEmployee(int employeeId, string fullName, float salary) : 
            base(employeeId, fullName, salary)
        {

        }

        public new float getNetSalary()
        {
            return base.getNetSalary()/4.0f;
        }

        public new void printInformation()
        {
            Console.WriteLine("" + employeeId + ", " + fullName + " earns " + getNetSalary() + " per week.");
        }
    }
}
