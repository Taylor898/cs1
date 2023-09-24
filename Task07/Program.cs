Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());

if(n<0)
{
    n *= -1;
}
if(n < 1000 && n > 99)
{
int lastn = n % 10;
Console.WriteLine("Last digit is " + lastn);
}

else 
{
    Console.WriteLine("Error, Enter 3-digit number");
} 