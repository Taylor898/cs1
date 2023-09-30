Console.WriteLine("Enter your number");
int n = Convert.ToInt32(Console.ReadLine());

if(n / 100 < 1)
{
    Console.WriteLine("No third digit");
}

else
{
    while(n / 100 > 10)
    {
        n = n / 10;
    }

    n = n % 10;
    Console.WriteLine(n);
}