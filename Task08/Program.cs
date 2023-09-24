Console.WriteLine("Enter your number");
int n = Convert.ToInt32(Console.ReadLine());
int t = 2;

while(t <= n)
{
    Console.Write($"{t}, ");
    t = t + 2;
}
