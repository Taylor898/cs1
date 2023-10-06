Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B:");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

if(B < 0)
{
    Console.WriteLine("Enter a valid number");
}

else {for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine($"Результат: {result}");
}
