Console.WriteLine("Enter 9 numbers=>");
int[] numbers = new int[9];
int max = numbers[0];
int min = numbers.Length;
int sum = 0;

for (int i = 0; i < numbers.Length; i++) 
{
    Console.WriteLine($"Enter {i + 1} value: ");
    numbers[i] = int.Parse(Console.ReadLine());
    if (numbers[i] > max) 
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    sum += numbers[i];
}

float avg = (float)sum / numbers.Length;

Console.WriteLine($"Min number is {min}");
Console.WriteLine($"Max number is {max}");
Console.WriteLine($"Avg number is {avg:N2}");
