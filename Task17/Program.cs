Console.WriteLine("Enter x");
int xc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);
 
string result = quarter > 0 
                ? $"Your quater is {quarter}"
                : "enter again";

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

