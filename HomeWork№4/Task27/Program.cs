// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum = 0;
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= number; i++)
{
     sum += number % 10;
     number = number / 10;
}
Console.WriteLine($"Сумма цифр равняется {sum}");