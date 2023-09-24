Console.WriteLine("Enter your first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second number");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your third number");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2>n1)
{
max = n2; 
}
if (n3>n2)
{
    max = n3;
}
else if(n3>n1)
{
    max = n3;
}
Console.WriteLine($"Your highest number is {max}");