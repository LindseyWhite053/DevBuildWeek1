// For loop when you want to repeat an action for all parts of an object

for (int index = 0; index < 10; index++)
{
    Console.WriteLine(index);
}

Console.WriteLine("------------------");

for (int index = 0; index < 10; index+=2)
{
    Console.WriteLine(index);
}


Console.WriteLine("------------------");

for (int i = 21; i >= 0; i -=3 )
{
    Console.WriteLine(i);
}

Console.WriteLine("All done with for loops!");
Console.WriteLine();


//While Loop completes an action while an operation validates true

int w = 1;

while (w < 5)
{
    Console.WriteLine("Inside while loop");
    Console.WriteLine(w);

    w++;
}

Console.WriteLine("------------------");

//example of a break statement inside a while loop

int w2 = 10;
while (w2 >= 0)
{
    if (w2 == 4)
    {
        Console.WriteLine("Oops, found corrupted data");
        break; // This exits the loop immediately
    }
    Console.WriteLine(w2);
    w2--;
}

Console.WriteLine("Finished with while loops.");
Console.WriteLine();


// Do while loops. Tests the condition after each iteration is complete

int w3 = 0;
do
{
    Console.WriteLine(w3);
    w3++;
} 
while (w3 < 10);

Console.WriteLine("All done with while loops!");

//Nested for loop. Means a for loop inside of a for loop
for (int x = 0; x <= 5; x++)
{
    Console.WriteLine($"Starting outer loop. x is {x}");
    
    for (int y = 0; y <= 3; y++)
    {
        Console.WriteLine($"x:{x} y:{y}");
    }
}

Console.WriteLine("Lets think of a clock");

for (int hour = 0; hour < 24; hour++)
{
    Console.WriteLine($"The hour is {hour}");
    for (int minute = 0; minute < 60; minute++)
    {
        Console.WriteLine($" {hour}:{minute}");
    }
}