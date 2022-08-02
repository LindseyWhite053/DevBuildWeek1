

bool keepGoing = true;

do
{
    //Ask the user to enter a number 
    Console.Write("Please enter a number: ");
    string entry = Console.ReadLine();


    //print out the square of the number 
    double num = double.Parse(entry);
    Console.WriteLine($"That number squared is {num * num}");

    //Ask the user if they would line to go again. Enter y or yes to go again , n or no to quit. 
    bool valid = false;
    do
    {
        Console.Write("Would you line to go again? (y/n) ");
        string answer = Console.ReadLine().ToLower();


        //confirm if a valid response was given    
        if (answer == "y" || answer == "yes")
        {
            valid = true;
            keepGoing = true;
        } else if (answer == "n" || answer == "no")
        {
            valid = true;
            keepGoing = false;
            Console.WriteLine("Goodbye");
        }

    } while (valid == false);


} while (keepGoing == true);


