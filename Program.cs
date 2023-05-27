namespace ConsoleAppI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fizzbuzz.Run();

            var numberArgs = new[] { "3", "8", "10" };
            ConsoleArguments.Run(numberArgs);

            Lesson02.DataClass(args);

            Lesson02.ServiceClass(args);

            Deserialize.DeserializeDerpi();
        }
    }
}