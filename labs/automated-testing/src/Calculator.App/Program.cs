using Calculator.App.Services;

namespace Calculator.App;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: {x + y}");
        }
        else if (args[1] != "+")
        {
            Console.WriteLine("Only addition is supported");
        }
        else
        {
            int left = 0;
            int.TryParse(args[0], out left);
            
            int right = 0;
            int.TryParse(args[2], out right);

            var service = new AdditionService();
            var result = service.Operate(left, right);

            Console.WriteLine($"{result}");
        }
    }
}
