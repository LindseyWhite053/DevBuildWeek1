Console.WriteLine("Welcome to the Dice Roller!");

//ask the user to enter the number of sides for a pair of dice. 
//make sure the user can only enter numbers
Console.WriteLine("How many sides would you like the dice to have?");
string userInput = Console.ReadLine();
int sides;
bool valid = false;
bool isRealInteger = int.TryParse(userInput, out sides);


while (valid == false)
{

    if (isRealInteger == false)
    {
        Console.WriteLine("Please enter a valid number");
        userInput = Console.ReadLine();
        isRealInteger = int.TryParse(userInput, out sides);

    }
    else
    {
        Console.WriteLine($"Your dice will have {sides} sides.");
        valid = true;
    }

}

//prompt the user to roll the dice.
bool roll = false;
while (roll == false)
{
    bool rollAgain = true;
    while (rollAgain == true)
    {     
    
        Console.Write("\nType \"r\" to roll the dice or \"e\" to exit the game: ");
        string input = Console.ReadLine().ToLower();
        //confirm if a valid response was given    
        if (input == "r" || input == "roll")
        {
            roll = true;

            DiceRoll(sides);

            //ask the user if they want to roll the dice again. 
            Console.Write("\n\nWould you like to roll again? ");
        }
        else if (input == "e" || input == "exit")
        {
            roll = true;
            rollAgain = false;
            Console.WriteLine("Goodbye");
            break;
        }
    }
}

// generate the random numbers for each dice.
static void DiceRoll(int side)
{
    int sideMax = side + 1;
    Random ran = new Random();
    int dice1 = ran.Next(1, sideMax);
    int dice2 = ran.Next(1, sideMax);

    //display the results of each dice along with a total
    Console.WriteLine($"Your dice rolled {dice1} and {dice2}");


    if (side == 6)
    {
        string combo = D6Combos(dice1, dice2);
        Console.WriteLine(combo);

    }
    else
    {
        Console.Write($"Your dice have a total of {dice1 + dice2}");
    }

}


//for six - sided dice display a message when a valid combination is rolled
static string D6Combos (int dice1, int dice2)
{

    string message1;
    
    if (dice1 == 1 && dice2 == 1) //Snake Eyes: Two 1s
    {
        message1 = "Snake Eyes!";
    } 
    else if (dice1 == 1 && dice2 ==2 || dice1 == 2 && dice2 == 1) //Ace Deuce: A 1 and 2
    {
        message1 = "Ace Deuce!";
    }
    else if (dice1 == 6 && dice2 == 6) //Box Cars: Two 6s
    {
        message1 = "Box Cars!";
    }
    else if (dice1 + dice2 == 7 ) //Win: A total of 7 or 11
    {
        message1 = "You win with a total of 7!";
    }
    else if (dice1 + dice2 == 11) //Win: A total of 7 or 11
    {
        message1 = "You win with a total of 11!";
    } else
    {
       message1 = $"Your dice have a total of {dice1 + dice2}";
    }

    string message2 = Craps(dice1, dice2);

    return message1 + message2;

}

static string Craps(int dice1, int dice2)
{

    int total = dice1 + dice2;

    if (total == 2 || total == 3 || total == 12)
    {
        string message2 = " Craps!";
        return message2;

    } else
    {
        return "";
    }
}
