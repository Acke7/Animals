namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine($"My wolf has {dog.NumbersOflegs} legs");
            Console.WriteLine($"My wolf says {dog.Bark()}!");
            Console.WriteLine("Feeding my wolf...");
            dog.Eat();
            Console.WriteLine("Resting my wolf...");
            dog.Sleep();
        }
    }
}
