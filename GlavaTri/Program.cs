using System;

namespace GlavaTri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Countdown(5);
            Greet("adit");
            Console.WriteLine(Fact(4));
        }

        private static void Countdown(int i)
        {
            Console.WriteLine(i);

            // base case
            if (i <= 0) return;

            // recursive case
            Countdown(i - 1);
        }

        private static void Greet(string name)
        {
            Console.WriteLine($"hello, {name}!");
            Greet2(name);
            Console.WriteLine("getting ready to say bye...");
            Bye();
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"how are you, {name}?");
        }

        private static void Bye()
        {
            Console.WriteLine("ok bye!");
        }



        private static int Fact(int x)
        {
            if (x <= 1) return 1;

            return x * Fact(x - 1);
        }
    }
}

