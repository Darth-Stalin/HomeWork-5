//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число ");
int Number = int.Parse(Console.ReadLine());
if (Number >= 100 && Number < 1000)
{
    int a = Number % 100;
    int b = Number % 10;
    int res = (a - b) / 10;
    Console.WriteLine("Второе число " + res);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}