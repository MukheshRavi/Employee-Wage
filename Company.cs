using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class Company
    {

        internal string companyName;
        internal int wagePerHour;
        internal int maxWorkingDays;
        internal int maxWorkingHours;
        internal int totalEmpWage;
        public Company(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;

        }

        public void saveTotalWage(int totalWage)
        {
            totalEmpWage = totalWage;
        }

    }
}
