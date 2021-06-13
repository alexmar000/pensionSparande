using System;

namespace pension_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            int age = Convert.ToInt32(userAge);
            int money = 15000;

            do
            {
                if (money > 20000 || age < 60)
                {
                    Console.WriteLine("You are saving little.");
                    money = money + 500;
                }
                else
                {
                    Console.WriteLine("You are saving a lot.");
                    money = money + 1000;
                }
                age++;
            }
            while (money < 20000 && age < 65);

            Console.WriteLine("You are retired by the age of " + age + ".");
            Console.WriteLine("You have saved " + money + " dollars.");

            Console.ReadKey();
        }
    }
}
