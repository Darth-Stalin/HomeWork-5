// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели в формате от 1 до 7 ");
int Day = int.Parse(Console.ReadLine());
if (Day >= 1 && Day < 6)
{
    Console.WriteLine("Пора на работу");
}
else if (Day == 6 || Day == 7)
{
    Console.WriteLine("Ура, выходные");
}
else
{
    Console.WriteLine("Ты что? У нас нет столько дней в неделе");
}