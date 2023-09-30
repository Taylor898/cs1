Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 7;
int n2 = 23;

if (n % n1 == 0 && n % n2 == 0)
{
    Console.WriteLine($"{n} -> Yes");
}
else
{
    Console.WriteLine($"{n} -> No");
}

