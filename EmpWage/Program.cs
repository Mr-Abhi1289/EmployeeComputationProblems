using System;
using System.ComponentModel;

namespace EmpWage
{
    internal class Program
    {

        public const int FullTime = 1;
        public const int PartTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumberofWorkingDays = 20;
        public const int MaxHrsInMonth = 100;


        public static int computeEmpWage()
        {
            int EmpHrs = 0, TotalEmpHrs = 0, totalworkingdays = 0;

            while (TotalEmpHrs<=MaxHrsInMonth && totalworkingdays<NumberofWorkingDays)

            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
     
                 switch (empcheck)
                {
                    case PartTime:
                        EmpHrs = 4;
                        break;
                    case FullTime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }

                TotalEmpHrs = TotalEmpHrs + EmpHrs;
                Console.WriteLine("day:" + totalworkingdays + " employee hours: " + EmpHrs);
            }
            int TotalEmpWage = TotalEmpHrs * EmpRatePerHr;

            Console.WriteLine("total employee wage:"+TotalEmpWage);
            return TotalEmpWage;

        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
           
    }
}