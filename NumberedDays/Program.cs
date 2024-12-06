Console.WriteLine("Enter the number corresponding to the day of the week (1-7): ");
int numberedDay = int.Parse(Console.ReadLine());

string namedDay;

switch (numberedDay)
{
    case 1:
        namedDay = "Monday";
        break;
    case 2:
        namedDay = "Tuesday";
        break;
    case 3:
        namedDay = "Wednesday";
        break;
    case 4:
        namedDay = "Thursday";
        break;
    case 5:
        namedDay = "Friday";
        break;
    case 6:
        namedDay = "Saturday";
        break;
    case 7:
        namedDay = "Sunday";
        break;
    default:
        throw new Exception("Invalid day number.");
}

Console.WriteLine($"Day of the week: {namedDay}");