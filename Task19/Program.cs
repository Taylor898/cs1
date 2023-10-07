using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      // Проверка на пятизначность
      if (number >= 10000 && number <= 99999)
      {
        int oNumber = number;
        int rNumber = 0;
        
        while (number > 0)
        {
          int rem = number % 10; // Берет последнюю цифру числа>
          rNumber = (rNumber * 10) + rem; // выстраивает перевернутое число
          number = number / 10; // убирает последнюю цифру исходного числа
        }
        return oNumber == rNumber; // сверяет исходное и перевернутое число
      }
      Console.WriteLine("Число не пятизначное");
      return false; // если число не пятизначное выводит false
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 333;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}