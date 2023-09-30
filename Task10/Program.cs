Console.WriteLine("Enter 3-digit n1");
int n = Convert.ToInt32(Console.ReadLine());

if(n / 100 > 0 && n / 100 < 10)
{
   n = n / 10;
   n = n % 10;
   Console.WriteLine(n);
}
else
{
    Console.WriteLine("Try again with a 3-digit n1");
}