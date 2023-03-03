using Humanizer;

namespace HelloWorld;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        if (args.Length == 1)
        {
            int bedtimeHour = 22;
            int.TryParse(args[0], out bedtimeHour);
            var today = DateTime.Today;
            var bedtime = new DateTime(today.Year, today.Month, today.Day, bedtimeHour, 0, 0);
            var duration = bedtime.Subtract(DateTime.Now);
            Console.WriteLine($"{duration.Humanize()} until bedtime.");
        }
    }
}