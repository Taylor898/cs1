// Math.Pow(4, 6);
// Math.Sqrt(5);

// double d = 5.099898;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

Console.WriteLine("Enter coordinates of x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates of x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates of y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates of y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1,x2,y1,y2);

Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xValue1, int xValue2, int yValue1, int yValue2)
{
    double result = Math.Sqrt(Math.Pow((xValue2 - xValue1), 2) + Math.Pow((yValue2 - yValue1), 2));
    return result;
}