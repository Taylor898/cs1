Console.WriteLine("Enter n1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n2");
int n2 = Convert.ToInt32(Console.ReadLine());

bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool result = IsSquareTwoNumbers(n1, n2);
Console.WriteLine(result ? $"{n1}, {n2} -> Yes" : $"{n1}, {n2} -> No");