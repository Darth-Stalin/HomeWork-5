// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int [size];
ArrayRandomNumbers(randomArray);
Console.WriteLine("Наш массив: ");
PrintArray(randomArray);
int sum = 0;

for(int i = 1; i < randomArray.Length; i = i + 2)
{
    sum += randomArray[i];
}
Console.WriteLine($"Сумма значений на нечетных позициях = {sum}");

void ArrayRandomNumbers(int[] randomArray)
{
for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0,10);
    }
}

void PrintArray(int[] randomArray)
{
    for(int i = 0; i < randomArray.Length; i++)
    {
        Console.Write(randomArray[i] + " ");
    }
    Console.WriteLine();
}