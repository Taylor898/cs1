// Console.WriteLine("Enter your number");
// int n = Convert.ToInt32(Console.ReadLine());

// int j = 1;
// while(j <= n)
// {
//     Console.WriteLine($"{j} -> {j * j}");
//     j++;
// }

Console.Write("Enter your number");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);

void TableSquare(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count} -> {count * count}");
        count++;
    }
}