using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_ModelAnswer
{
    class PayrollRunner
    {
        static void Main(string[] args)
        {
            // use Employee without tax
            Employee john = new Employee(1, "John Doe", 20000, false);
            john.printInformation();

            // use Employee with tax
            Employee jane = new Employee(2, "Jane Doe", 36000);
            jane.printInformation();

            // use WeeklyEmployee without tax
            WeeklyEmployee jack = new WeeklyEmployee(3, "Jack Deer", 18500, false);
            jack.printInformation();

            // use WeeklyEmployee with tax
            WeeklyEmployee jen = new WeeklyEmployee(4, "Jen Deer", 18000);
            jen.printInformation();

            Console.Read();
        }
    }
}
