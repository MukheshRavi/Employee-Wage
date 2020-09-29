using System;

namespace Employee_Wage_Computation1
{
    class Program
    {
        // constants
        const int WAGE_PER_HOUR = 20;
        const int MAX_WORKDAYS_IN_MONTH = 20;
        const int MAX_WORK_HOURS = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Program program = new Program();
            program.CalculateTotalWage();

        }

        public void CalculateTotalWage() //Method to calculate total wage
        {
            //variables
            int dailyWage = 0;
            int dailyEmpHours = 0;
            int numberOfWorkDays = 0;
            int totalEmpWorkHours = 0;
            int totalMonthlyWage;
            while (totalEmpWorkHours < MAX_WORK_HOURS && numberOfWorkDays < MAX_WORKDAYS_IN_MONTH)
            {
                numberOfWorkDays++;                         // Calculates No of working days till now in month
                dailyEmpHours = CalculateDailyEmpHours();   // Calculates No of working hours daily
                dailyWage = dailyEmpHours * WAGE_PER_HOUR;
                Console.WriteLine("The daily Wage of employee on day {0} is {1}", numberOfWorkDays, dailyWage);

                // calculates total working hours
                if (totalEmpWorkHours + dailyEmpHours <= MAX_WORK_HOURS)
                    totalEmpWorkHours += dailyEmpHours;
                else
                    totalEmpWorkHours = MAX_WORK_HOURS;
            }
            totalMonthlyWage = totalEmpWorkHours * WAGE_PER_HOUR;
            Console.WriteLine("The monthly wage of employee is {0}", totalMonthlyWage);


        }

        public int CalculateDailyEmpHours() //Method to calculate daily work hours of employee
        {
            // constants
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            //variables
            int empHours = 0;
            Random random = new Random();
            int workType = random.Next(0, 3);
            switch (workType)
            {
                case IS_FULL_TIME:

                    empHours = 8;       //emp present for full day on that working day
                    break;

                case IS_PART_TIME:

                    empHours = 4;      //emp present for part time on that working day
                    break;

                default:

                    empHours = 0;
                    break;
            }
            return empHours;
        }

    }
}