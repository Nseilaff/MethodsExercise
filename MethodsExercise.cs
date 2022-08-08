using System;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoryTime();
            var answer = Add();
            Console.WriteLine(answer);
            var answer2 = Multiply();
            Console.WriteLine(answer2);
            var answer3 = Divide();
            Console.WriteLine(answer3);
        }
        public static void StoryTime()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favoite place");
            var place = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            var animal = Console.ReadLine();
            Console.WriteLine($"When you see {animal} You decide to?");
            var decision = Console.ReadLine();

            Console.WriteLine($"Hello there {name}, You are walking along in {place}. While walking you see {animal} and you {decision}. ");

        }
        public static int Add()
        {
            Console.WriteLine("Enter your first number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            var num2 = int.Parse(Console.ReadLine());
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply()
        {
            Console.WriteLine("First Number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            var num2 = int.Parse(Console.ReadLine());
            var answer2 = num1 * num2;
            Console.WriteLine("Your muliplied answer is:");
            return answer2;

        }
        public static int Divide()
        {
            Console.WriteLine("First Number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            var num2 = int.Parse(Console.ReadLine());
            var answer3 = num1 / num2;
            Console.WriteLine("Your divided answer is:");
            return answer3;

        }

    }
}
