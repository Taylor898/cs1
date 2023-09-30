int n = new Random().Next(100, 1000);
Console.WriteLine($"На вход получаем число -> {n}");
int firstNumber = n / 100;
int lastNumber = n %10;
int res = firstNumber * 10 + lastNumber;
Console.WriteLine($"Двухзначное число -> {res}");
