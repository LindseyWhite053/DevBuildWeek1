
bool goAgain = false;
do

{
// prompt the user to enter an integer between 1 and 100 inclusive
Console.Write("Please enter a number between 1 and 100: ");
int num = Convert.ToInt32(Console.ReadLine());

//evaluate if the integer is even or odd 
bool isEven;

if (num % 2 == 0)
{
    isEven = true;
} else
{
    isEven = false;
}

//Outputs a number description based on the group it falls under. 
    if (!isEven && num < 60)
    {
        Console.WriteLine($"{num} is odd and less than 60.");
    }
    else if (isEven && num >= 2 && num <= 24)
    {
        Console.WriteLine($"{num} is even and less than 25.");
    }
    else if (isEven && num >= 26 && num <= 60)
    {
        Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
    }
    else if (isEven && num > 60)
    {
        Console.WriteLine($"{num} is even and greater than 60.");
    }
    else if (!isEven && num > 60)
    {
        Console.WriteLine($"{num} is odd and greater than 60.");
    }

    
    bool valid = false;
    do
    {

        Console.Write("Would you like to evaluate another number? (y/n) ");
        string answer = Console.ReadLine().ToLower();


        if (answer == "y" || answer == "yes")
        {        

            valid = true;
            goAgain = true;
        }
        else if (answer == "n" || answer == "no")
        {
            valid = true;
            goAgain = false;
            Console.WriteLine("Goodbye");
        } 

    } while (valid == false);


} while (goAgain == true);
