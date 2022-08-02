//Console.WriteLine("What is your name? ");
//string entry = Console.ReadLine();
//Console.WriteLine($"Great to meet you, {entry}");

Console.WriteLine("Please enter a number: ");

string entry = Console.ReadLine();
int n = int.Parse(entry); //takes the string typed in and changes it to the correct data type

if ( n > 50 )
{
    Console.WriteLine($"n is {n}"); //use the $ to use interpolation.
    Console.WriteLine("Yes, n is greater than 50");

} else
{
    Console.WriteLine($"n is {n}");    
    Console.WriteLine("No, n is not greater than 50.");
}

//confirm if the number is between 3 and 10 exclusive
if ( n > 3 && n < 10)
{
    Console.WriteLine("n is between 3 and 10 exclusive.");
} else
{
    Console.WriteLine("n is not between 3 and 10 exclusive.");
}

//confirm if the number is between 3 and 10 inclusive
if (n >= 3 && n <= 10)
{
    Console.WriteLine("n is between 3 and 10 inclusive.");
}
else
{
    Console.WriteLine("n is not between 3 and 10 inclusive.");
}