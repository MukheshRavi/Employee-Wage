using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = Attendance();
            int dailyEmployeeWage = 0, partTimeWage = 0;
            switch (isPresent)
            {
                case 0:
                    Console.WriteLine("Employee is Absent!");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present!");
                    dailyEmployeeWage = DailyEmployeeWage();
                    int doPartTime = Attendance();
                    if (doPartTime == 1)
                        partTimeWage = PartTimeWage();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Daily Employee Wage : {0}", dailyEmployeeWage);
            Console.WriteLine("Part Time Employee Wage : {0}", partTimeWage);
        }
        /// <summary>
        /// Attendance function returns 0 or 1 randomly.
        /// </summary>
        /// <returns></returns>
        static int Attendance()
        {
            Random randObj = new Random();
            return randObj.Next(0, 2);
        }

        static int DailyEmployeeWage()
        {
            int fullDayHour = 8;
            int perHourWage = 20;
            return fullDayHour * perHourWage;
        }

        static int PartTimeWage()
        {
            int partTimeHour = 4;
            int perHourWage = 20;
            return partTimeHour * perHourWage;
        }
    }
}