//Integers 
int x = 10;
x = x * 2;
x++;
Console.WriteLine(x); //expect to see 21

//Strings

string product = "Monitor";
product = product.ToUpper();
Console.WriteLine(product); //expect to see MONITOR

//Double

double first = 2.5;
double pi = Math.PI;

Console.WriteLine(first);
Console.WriteLine(pi);

double mult = first * pi;
Console.WriteLine(mult);

double mult2 = first * Math.PI;
Console.WriteLine(mult2);

//Decimal(money)

decimal charge = 10.25m;

decimal perc = charge / 3;
Console.WriteLine(perc);

//Boolean

bool finished = false;
Console.WriteLine(finished); //expect to see False

bool another = !finished;
Console.WriteLine(another); //expect to see True

Console.WriteLine();
Console.WriteLine("Expressions that are true or false");
int q = 20;
bool test1 = (q > 10); //q is greater than 10. True or false? output is true because 20 is greater than 10.
Console.WriteLine(test1);

Console.WriteLine(q > 30); // "q is greater than 30". Expect to see False
Console.WriteLine(q == 20); // "q is equal to 20". Expect to see True
Console.WriteLine(q != 20); // "q is not equal to 20". Expect to see False
Console.WriteLine( !(q != 20) ); // "q is not equal to 20 is not false". Expect to see True

//Let's add in "and" "or"
int j = 10;
int k = 11;

Console.WriteLine( j == 10 && k == 11 ); //"j equals 10 AND k equals 11". Expect to see True

Console.WriteLine(j == 10 && k != 11); //"j equals 10 AND k does NOT equal 11. Expect to see False

Console.WriteLine(j == 10 || k == 12); //"j equals 10 OR k equals 12". Expect to see True 


