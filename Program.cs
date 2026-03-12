namespace Methods_MORGAN_JOSEPH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //Im leaving ts here
            IntegerMultiplier(); //Calling the method to multiply two integers and display the result
            introduction(); //Calling the method to ask for the user's name and greet them
            goodbye(); //Calling the method to say goodbye to the user
        }
        static void IntegerMultiplier() //defining a method to multiply two integers and display the result
        {
           int num1 = 5; //Defining the first integer to be multiplied
            int num2 = 10; //Defining the second integer to be multiplied

            int result = num1 * num2; //Calculating the product of the two integers and storing it in a variable
            Console.WriteLine($" 5 * 10 = {result}"); //Displaying the result of the multiplication to the console
        }
        static void introduction() //defining a method to ask for the user's name and greet them
        {
         
            Console.WriteLine("What is your name?"); //Asking the user for their name
            string name = Console.ReadLine(); //Reading the user's input and storing it in a variable
            Console.WriteLine($"Hello, {name}! It is nice to meet you!"); //Greeting the user by name and displaying a message to the console

        }
        static void goodbye() //defining a method to say goodbye to the user
        {
            Console.WriteLine("Have a fantastic day, wigga!"); //Displaying a goodbye message to the user in the console and saying wigga!
        }
    }
}
