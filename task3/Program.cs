  //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели - ");
int DayNumber = int.Parse(Console.ReadLine());

if ((DayNumber == 6) || (DayNumber == 7))
{
  Console.WriteLine($"День недели - {DayNumber}, является выходным.");
}
else
{
  Console.WriteLine($"День недели - {DayNumber}, не является выходным.");
}

// получение дня с помощью генератора случайных чисел


// int DayNumber = new Random().Next(1,8);

// if ((DayNumber == 6) || (DayNumber == 7))
// {
//   Console.WriteLine($"День недели - {DayNumber}, является выходным.");
// }
// if (DayNumber == 5)
// {
//   Console.WriteLine($"День недели - {DayNumber}. Пятница - небольшой прадник");  // для лентяев))
// }
// if ((DayNumber == 4) || (DayNumber == 3) || (DayNumber == 2) || (DayNumber == 1))
// {
//   Console.WriteLine($"День недели - {DayNumber}, не является выходным.");
// }