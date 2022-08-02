bool keepGoing = false;
do

{
    
//prompt the user to enter an integer. Assuming the user enters valid data
Console.Write("Enter a number to see it squared and cubed: ");
int number = Convert.ToInt32(Console.ReadLine());


//display a table of squares and cubes from 1 to the value entered 
Console.WriteLine("{0,-7} {1, -7} {2, -7}", "Number", "Squared", "Cubed");
Console.WriteLine("{0,-7} {1, -7} {2, -7}", "-------", "-------", "-------");


    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0,7} {1, 7} {2, 7}", i, i * i, i * i * i);
    }



    //Ask the user if they would line to go again. Enter y or yes to go again , n or no to quit. 
    bool valid = false;
    do
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
            Console.WriteLine("Goodbye");
            break;
        }

    } while (valid == false);


} while (keepGoing == true);




//Extra: Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.

//Extra: Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less
