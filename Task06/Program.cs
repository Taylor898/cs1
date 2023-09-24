Console.WriteLine("Enter your number");
int n = Convert.ToInt32(Console.ReadLine());

int n2 = n % 2;

if(n2 == 0)
{
    Console.WriteLine("Your number is even!");
}
else
{
    Console.WriteLine("Your number is odd");
}