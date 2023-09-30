Console.WriteLine("Enter n1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2");
int n2 = Convert.ToInt32(Console.ReadLine());

int nd = n1 % n2;

if(nd == 0)
{ 
    Console.WriteLine("No leftover");
}
else
{
    Console.WriteLine("Enter ns again");
}