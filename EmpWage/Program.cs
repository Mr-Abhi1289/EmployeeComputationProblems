namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int PartTime = 2;
            int EmpRatePerHr = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random randobj=new Random();
            int checkpresent = randobj.Next(0, 3);
            if (checkpresent == PartTime)
            {
                EmpHrs = 4;
            }
            else if (checkpresent == FullTime) 
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * EmpRatePerHr;
            Console.WriteLine("Employee daily wage:" + EmpWage);
        }
    }
}