Console.WriteLine("Enter three angles of a triangle: ");

Console.Write("Angle 1: ");
int angle1 = int.Parse(Console.ReadLine());

Console.Write("Angle 2: ");
int angle2 = int.Parse(Console.ReadLine());

Console.Write("Angle 3: ");
int angle3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Entered angles are: {angle1}, {angle2}, {angle3}");

if(angle1 > 0 && angle2 > 0 && angle3 > 0) 
{ 
    if(angle1 + angle2 + angle3 == 180) 
    {
        Console.WriteLine("The angles form a triangle.");
    }
    else 
    {
        Console.WriteLine("The angles do not form a triangle because their sum does not equal 180.");
    }
}
else
{
    Console.WriteLine("The angles do not form a triangle because one or more angles is not greater than 0.");
}

