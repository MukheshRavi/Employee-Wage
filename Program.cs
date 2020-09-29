using System;

namespace Employee_Wage_Computation1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Program program = new Program();
            program.CalculateTotalWage("Amazon", 40, 25, 100);
            program.CalculateTotalWage("flipkart", 60, 15, 80);


        }

        public void CalculateTotalWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours) //Method to calculate total wage
        {

            //variables
            int dailyWage = 0;
            int dailyEmpHours = 0;
            int day = 0;
            int totalEmpWorkHours = 0;
            int totalMonthlyWage;
            while (totalEmpWorkHours < maxWorkingHours && day < maxWorkingDays)
            {
                day++;                         // Calculates No of working days till now in month
                dailyEmpHours = CalculateDailyEmpHours();   // Calculates No of working hours daily
                dailyWage = dailyEmpHours * wagePerHour;
                Console.WriteLine("The daily Wage of employee on day {0} is {1}", day, dailyWage);

                // calculates total working hours
                if (totalEmpWorkHours + dailyEmpHours <= maxWorkingHours)
                    totalEmpWorkHours += dailyEmpHours;
                else
                    totalEmpWorkHours = maxWorkingHours;
            }
            totalMonthlyWage = totalEmpWorkHours * wagePerHour;
            Console.WriteLine("The monthly wage for {1} is {0}", totalMonthlyWage, companyName);


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