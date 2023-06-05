// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[size];
ArrayRandomNumbers(randomArray);
Console.WriteLine("Наш массив: ");
PrintArray(randomArray);
int count = 0;

for (int i = 0; i < randomArray.Length; i++)
{
    if(randomArray[i] % 2 == 0)
    count ++;
}
Console.WriteLine($"Колличество четных значений: {count}");

void ArrayRandomNumbers(int[] randomArray)
{
for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
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