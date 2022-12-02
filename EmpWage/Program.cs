﻿using System;

namespace EmpWage
{
    internal class Program
    {

        public const int FullTime = 1;
        public const int PartTime = 2;
        public const int EmpRatePerHr = 20;
        public const int NumberofWorkingDays = 20;


        static void Main(string[] args)
        {
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotalEmpWage = 0;



            for ( int day = 0; day < NumberofWorkingDays; day++)
            {
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



                EmpWage = EmpHrs * EmpRatePerHr;
                TotalEmpWage = TotalEmpWage + EmpWage;
                Console.WriteLine("Employee daily wage:" + EmpWage);
            }
            Console.WriteLine("total employee wage:"+TotalEmpWage);

        }
           
    }
}