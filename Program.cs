namespace assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year to check if its Leap year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}
