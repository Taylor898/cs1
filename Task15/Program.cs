Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

bool IsWeekend(int n)
{
    if (n > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday (int n)
{
    if (n > 0 && n <= 7)
    {
        return true;
    }
    Console.WriteLine("This is not a day of the week");
    return false;
}

if (ValidateWeekday(n))
{
    if (IsWeekend(n))
    {
        Console.WriteLine("weekend");
    }
    else
    {
        Console.WriteLine("Working day");
    }
}