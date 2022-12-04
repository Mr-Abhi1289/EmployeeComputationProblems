namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int EmpRatePerHr = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random randobj=new Random();
            int checkpresent = randobj.Next(0, 2);
            if (checkpresent == FullTime)
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
