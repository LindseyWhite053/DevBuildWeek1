string name = "Fred";
Console.WriteLine(name);

string upperName = name.ToUpper();
Console.WriteLine(upperName);


Console.WriteLine(name.ToLower());


Console.WriteLine(name[0]);
Console.WriteLine(name[1]);
Console.WriteLine(name[2]);
Console.WriteLine(name[3]);

//floating point types 
double pi = 3.1415926;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);

Console.WriteLine(Math.Sqrt(pi));

double q = Math.Sqrt(25);
Console.WriteLine(q);

//float n = 3.1415926f; rarely used. must include an f at the end to initialize the variable. 

decimal amount = 99.95m;
Console.WriteLine(amount);
amount = amount * 2;
Console.WriteLine(amount);

//boolean used to determine true or false
bool passed = true;
Console.WriteLine(passed);

passed = false;
Console.WriteLine(passed);

passed = !passed; //passed was false; the "not" operator flips it to true;
Console.WriteLine(passed);

