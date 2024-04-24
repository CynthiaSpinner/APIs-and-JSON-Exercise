using System;



namespace APIsAndJSON
{
    public class Program
    {
        static RonVSKanyeAPI instance = new RonVSKanyeAPI();
        static OpenWeatherMapAPI instance1 = new OpenWeatherMapAPI();
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Kanye West: {instance.KanYe()}");
                Console.WriteLine();
                Console.WriteLine($"Ron Swanson: {instance.RonSwanson()}");
            }

            Console.WriteLine();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();

            Console.WriteLine($"Weather in New York City: {instance1.weather()}");
        }
    }
}
