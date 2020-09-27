using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDailyWage = 0, totalPartTimeWage = 0;
            int workingDaysInMonth = 20;
            int totalWorkingHours = 0;
            bool flag = false;
            for (int i = 1; i <= workingDaysInMonth; i++)
            {
                int isPresent = Attendance();
                int dailyEmployeeWage = 0, partTimeWage = 0;
                switch (isPresent)
                {
                    case 0:
                        break;
                    case 1:
                        totalWorkingHours += 8;
                        if (totalWorkingHours > 100)
                        {
                            flag = true;
                            break;
                        }
                        dailyEmployeeWage = DailyEmployeeWage();
                        int doPartTime = Attendance();
                        if (doPartTime == 1)
                        {
                            totalWorkingHours += 4;
                            if (totalWorkingHours > 100)
                            {
                                flag = true;
                                break;
                            }
                            partTimeWage = PartTimeWage();
                        }

                        break;
                    default:
                        break;
                }
                if (flag)
                    break;
                totalDailyWage += dailyEmployeeWage;
                totalPartTimeWage += partTimeWage;
            }
            Console.WriteLine("Total Daily Employee Wage : {0}", totalDailyWage);
            Console.WriteLine("Total Part Time Employee Wage : {0}", totalPartTimeWage);
            Console.WriteLine("Total Wage : {0}", totalDailyWage + totalPartTimeWage);
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