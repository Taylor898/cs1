Console.WriteLine("Enter n1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2");
int n2 = Convert.ToInt32(Console.ReadLine());

int sq = n2 * n2;

if(n1 == sq)
{
    Console.WriteLine(n1 + " is n2 squared");
}
else {
    Console.WriteLine("Try again(");
}