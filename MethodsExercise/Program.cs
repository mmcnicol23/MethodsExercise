namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();

            int added = Add(3, 5);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 6);
            Console.WriteLine(subtracted);

            int multiplied = Multiply(12, 12);
            Console.WriteLine(multiplied);

            int divided = Divide(36, 6);
            Console.WriteLine(divided);
        }
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}.");
            Console.WriteLine( );
          
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"I also like the color {color}.");
            Console.WriteLine( );
            
            Console.WriteLine("What's your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine($"I think I've seen {animal} at the zoo!");
            Console.WriteLine();

            Console.WriteLine("Just one more question. What's your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"I've heard {band} on the radio. They make good music.");
            Console.WriteLine();
            
            Console.WriteLine("I'm going to write a story using all of the information you gave me.");
            Console.WriteLine($"{name} is a good friend of mine. Their favorite animal is {animal} and their favorite color is {color}. They enjoy listening to {band} on the radio.");

        }
        
        //Add integers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        //Subtract integers
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        //Multiply integers
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        //Divide integers
        public static int Divide(int num1, int num2)
        {
            return num1 / num1;
        }
    }
}
