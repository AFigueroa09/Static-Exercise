namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = 1;
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(fahrenheit)}C");

            var celcius = 1;
            Console.WriteLine($"{TempConverter.CelciusToFahrenheit(celcius)}F");
        }
    }
}
