Console.WriteLine("Welcome to \"CalcOne\" - a simple calculator.");
Console.WriteLine("Please enter two numbers and answer the question.");
Console.WriteLine("First number:");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("What type of action do you want to perform (+, -, * or /)?");
char action = char.Parse(Console.ReadLine());
Console.WriteLine("Second number:");
double number2 = double.Parse(Console.ReadLine());
double result = 0;

switch (action) 
{
    case '+':
        result = number1 + number2;

    break;

    case '-':
        result = number1 - number2;
        break;

    case '*':
        result = number1 * number2;
        break;

    case '/':
        result = number1 / number2;
        break;
    default:
        throw new Exception("Input wasn't exactly +, -, * or /.");
}

Console.WriteLine($"You have chosen \'{action}\' operator and the result is {result:N2}.");