namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
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
    }
}
