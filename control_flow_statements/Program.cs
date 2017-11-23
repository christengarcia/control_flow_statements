using System;

namespace control_flow_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
            }
            else if (userAge < 21)
                Console.WriteLine("You need parental consent");
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!");
            }
        }
    }
}
