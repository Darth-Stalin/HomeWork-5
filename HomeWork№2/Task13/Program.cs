// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.


Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(Number);
if (numberText.Length > 2)
{
  Console.WriteLine("Третья цифра " + numberText[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}