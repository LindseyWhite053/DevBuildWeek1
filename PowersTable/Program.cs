
bool keepGoing = true;

while (keepGoing == true) 
{
    
    //prompt the user to enter an integer. Assuming the user enters valid data
    Console.Write("Enter a number to see it squared and cubed: ");
    int number = Convert.ToInt32(Console.ReadLine());

    // Validate the number is neither 0 nor a negative number 
    while (number <= 0 )
    {

        Console.Write("Invalid number. Enter a positive number to see it squared and cubed: ");
        number = Convert.ToInt32(Console.ReadLine());
    
    }

    //Limit the user input to the maximum number whose cube will fit in an int or less 
    while (number > 1290)
    {
        Console.Write("Number may not exceed 1290. Please enter a new number: ");
        number = Convert.ToInt32(Console.ReadLine());

    }


    Console.WriteLine();

    //display a table of squares and cubes from 1 to the value entered 
    Console.WriteLine("{0,-7} {1, -7} {2, -7}", "Number", "Squared", "Cubed");
    Console.WriteLine("{0,-7} {1, -7} {2, -7}", "-------", "-------", "-------");


    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0,7} {1, 7} {2, 7}", i, i * i, i * i * i);
    }


    //Ask the user if they would like to go again. Enter y or yes to go again , n or no to quit. 
    bool valid = false;
    
    while (valid == false)
    {
        Console.Write("Would you like to continue to a new number? (y/n) ");
        string answer = Console.ReadLine().ToLower();


        //confirm if a valid response was given    
        if (answer == "y" || answer == "yes")
        {
            valid = true;
            keepGoing = true;
        }
        else if (answer == "n" || answer == "no")
        {
            valid = true;
            keepGoing = false;
            Console.WriteLine("Goodbye!");
            break;
        }

    }
} 
