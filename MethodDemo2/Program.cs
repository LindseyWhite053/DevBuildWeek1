//Pass by reference 

double first = 3.5;
double second = 4.5;
double area = RectangleArea(ref first, ref second);
Console.WriteLine($"Rectangle {first} by {second} has area {area}");


static double RectangleArea(ref double length, ref double width)
{
    double result = length * width;
    length = 100.0;
    width = 100.0;
    return length * width;
}

//Out Parameter

double result;
bool worked = Divide(10, 2, out result);
if (worked)
{
	Console.WriteLine($"Great! The answer is {result}");
}
else
{
	Console.WriteLine("Sorry, you cannot divide by zero!");
}

static bool Divide(double num1, double num2, out double result)
{
	// check if num2 is zero. And if so, don't do it.
	if (num2 == 0)
	{
		result = 0;
		return false;
	}
	else
	{
		result = num1 / num2;
		return true;
	}
}