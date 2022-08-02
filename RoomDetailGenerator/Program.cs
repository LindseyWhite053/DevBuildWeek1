Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

try
{
    //Ask user for length and width
    Console.WriteLine("Enter room length: ");
    double length = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter room width: ");
    double width = Convert.ToDouble(Console.ReadLine());

    
    //calculate area and perimeter
    double area = length * width;

    double perim = (length * 2) + (width * 2);

    Console.WriteLine($"The area of the room is {area} ");
    Console.WriteLine($"The perimeter of the room is {perim}");

    //Determine small, medium, large 
    if (area <= 250)
    {
        Console.WriteLine("This is a small sized room.");
    }
    else if (area < 650)
    {
        Console.WriteLine("This is a medium sized room.");
    }
    else 
    {
        Console.WriteLine("This is a large sized room.");
    }

    Console.WriteLine("Thank you for using the Room Detail Generator!");

}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
