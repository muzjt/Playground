Console.WriteLine("Choose option:");
Console.WriteLine("1. Celsius to Fahrenheit conversion.");
Console.WriteLine("2. Fahrenheit to Celsius conversion.");

string choice =  Console.ReadLine();

if (choice == "1") 
{
    Console.WriteLine("Enter temperature in Celsius degrees:");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = CelsiusToFahrenheit(celsius);
    Console.WriteLine($"Temperature of {celsius} Celsius degrees converts to {fahrenheit:N0} Fahrenheit degrees.");
}
else if (choice == "2")
{
    Console.WriteLine("Enter temperature in Fahrenheit degrees:");
    double fahrenheit = Convert.ToDouble(Console.ReadLine());
    double celsius = FahrenheitToCelsius(fahrenheit);
    Console.WriteLine($"Temperature of {fahrenheit} Fahrenheit degrees converts to {celsius:N0} Celsius degrees.");
}
else 
{
    throw new Exception("Error, option doesn't exist.");
}

static double CelsiusToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

static double FahrenheitToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}
