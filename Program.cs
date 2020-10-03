using System;
using System.Collections;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            //Add the details of all the companyList first
            empWageBuilder.AddCompanyDetails("Reliance", 60, 20, 100);
            empWageBuilder.AddCompanyDetails("Amazon", 50, 15, 80);

            // Calculate the employee wage of all the companyList
            empWageBuilder.CalculateTotalEmpWage();

            empWageBuilder.GetWagesOfCompany("Reliance");

        }


    }
}

