using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem1
{
    internal class EmployeeUC2
    {
        public static void EmployeeWage ()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);


            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine(" Emplyee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Emplyee is Absent");
                empHrs = 0; 
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("EmpWage : " + empWage);
        }
    }
}
