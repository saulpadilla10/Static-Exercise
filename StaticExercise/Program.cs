namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(55);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(105);

            Console.WriteLine(celsius);

            Console.WriteLine(fahrenheit);

            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");

        }
    }
}
