// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int result = 1;
Console.WriteLine("Введите чило А ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натурально число B ");
int exp = Convert.ToInt32(Console.ReadLine());
 
if (exp <= 0)
{
    Console.WriteLine("Число B не натуральное");
}
else
{
    for(int i = 1; i <= exp; i++)
    result = result * number;
}
Console.WriteLine($"Число А в натуральной степени В равно {result}");