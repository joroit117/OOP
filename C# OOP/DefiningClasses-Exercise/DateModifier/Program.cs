using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier date = new DateModifier();
            double diff = date.GetDifferenceInDays(date1, date2);
            Console.WriteLine(diff);
        }
    }
}
