namespace Methods_MORGAN_JOSEPH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IntegerMultiplier();
            introduction();
            goodbye();
        }
        static void IntegerMultiplier()
        {
           int num1 = 5;
              int num2 = 10;

               int result = num1 * num2;
            Console.WriteLine($" 5 * 10 = {result}");
        }
        static void introduction()
        {
         
            Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! It is nice to meet you!");

        }
        static void goodbye()
        {
            Console.WriteLine("Have a fantastic day, wigga!");
        }
    }
}
