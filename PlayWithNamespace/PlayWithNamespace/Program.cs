using G = Galaxy;
using A = Alien;
using Alien;

namespace PlayWithNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play With C# Namespace");

            // We can use full namespace path to access specific object
            Galaxy.World.Print();
            Alien.World.Print();

            // Or we can using the namespace path at the top and use like this
            World.Print();

            // But here is one confusion. As my two namespace has same class name
            // In that case compiler is throwing an ambigous error.

            //World.Print();
            //World.Print();

            // For avoid this ambiguty we can use namespace aliece like that
            // using G = Galaxy
            // using A = Alien;

            // Then use the method
            G.World.Print();
            A.World.Print();

        }
    }
}


// Declare Two Namespace in one place.

namespace Galaxy
{
    class World
    {
        public static void Print()
        {
            Console.WriteLine("World From Galaxy");
        }
    }
}

namespace Alien
{
    class World
    {
        public static void Print()
        {
            Console.WriteLine("World From Alien");
        }
    }
}