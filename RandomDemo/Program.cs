//creates a new variable of type random
Random ran = new Random();

for (int i = 1; i <= 10; i++)
{
    int num = ran.Next(1, 7);
    Console.WriteLine(num);
}
