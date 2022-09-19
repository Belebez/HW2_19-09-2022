//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  первое решение

Console.Write("Введите число - ");
string number = Console.ReadLine();
int len = number.Length;
int num = int.Parse(number);

int degree = Convert.ToInt32(Math.Pow(10, (len - 3)));

if (num > 99)  //  проверка есть ли третье число
{
    int num3 = (num / degree) % 10;  //  получаем третье число 
    Console.WriteLine($"Третья цифра в числе - {number}, является - {num3}");
    
}
else
{
    Console.WriteLine($"В числе {number} нет третьего числа");
}


// это решение явно не такое простое, хотя в python оно будет выглядеть лаконичней

// num = int(input("Введите число - "))
// n = len(str(num))

// if num > 99:
//   num3 = (num // (10**(n-3)) ) % 10
//   print(f"Третья цифра в числе - {num}, является - {num3}")
// else:
//     print(f"В числе {num} нет третьего числа")

// второе решение

// Console.Write("Введите число - ");
// int number = int.Parse(Console.ReadLine());

// if (number < 100)
// {
//   Console.WriteLine($"В числе {number} нет третьего числа");
// }
// else
// {
//   Console.Write($"Третья цифра в числе - {number}");
//   while (number >= 1000)
//   {
//     number /= 10;
//   }
//   int num3 = number % 10;
//   Console.WriteLine($" является - {num3}");
// }