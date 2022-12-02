namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            Random randobj=new Random();
            int checkpresent = randobj.Next(0,2);
            Console.WriteLine("random numberis"+checkpresent);
            if (checkpresent == FullTime)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine(" employee is absent ")
            }
        }
    }
}