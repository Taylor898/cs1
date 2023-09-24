Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int nn = n - 2*n; //nn=negative n

while(nn <= n)
{
    Console.Write(nn);
    nn++;
}