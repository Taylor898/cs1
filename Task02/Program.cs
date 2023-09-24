Console.WriteLine("Enter your first number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n>n2)
{
    Console.WriteLine($"{n} is larger than {n2}");
}
if(n<n2)
{
    Console.WriteLine($"{n} is smaller than {n2}");
}
else if(n == n2)
{
    Console.WriteLine($"{n} is equal to {n2}");
}