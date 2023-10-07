string Quater(int q)
{
    if (q == 1) return "x > 0 && y > 0";
    if (q == 2) return "x < 0 && y > 0";
    if (q == 3) return "x < 0 && y < 0";
    if (q == 4) return "x > 0 && y < 0";
    return null;
}

Console.WriteLine("Enter");
int qu = Convert.ToInt32(Console.ReadLine());
string result = Quater(qu);
Console.WriteLine((result != null) ? result : "enter quarter number");