namespace IterationStatementsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            Console.WriteLine("WHILE LOOP:");
            var cont = "yes";
            while (cont == "yes")
            {
                Console.WriteLine("Continue? (Type 'yes' or 'no')");
                cont = Console.ReadLine();

            }

            Console.WriteLine("Outside of the loop");
            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //Do While loop
            Console.WriteLine("DO WHILE LOOP");
            var num = 1;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5);

            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //For loop
            Console.WriteLine("FOR LOOP");

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} is the number we are on");
            }

            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //Foreach loop
            Console.WriteLine("FOREACH LOOP");
            var numbers = new int[] { 12, 55, 900, 30, 2 };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}