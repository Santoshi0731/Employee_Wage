using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem1
{
    public class UC1
    {
        
       
            public static void CheckAttendance()
            {
                int IS_FULL_TIME = 1;
                Random random = new Random();
                int empCheck = random.Next(2);


                if (empCheck == IS_FULL_TIME)
                {
                    Console.WriteLine(" Emplyee is Present");
                }
                else
                {
                    Console.WriteLine("Emplyee is Absent");
                }
            }
        
    }
}
