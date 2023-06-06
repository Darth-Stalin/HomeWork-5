// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[size];
ArrayRandomNumbers(randomArray);
Console.WriteLine("Наш массив: ");
PrintArray(randomArray);
double razn = 0;
double max = randomArray[0];
double min = randomArray[0];

for (int i = 0; i < size; i++)
{
    if(min > randomArray[i])
    min = randomArray[i];
    if(max < randomArray[i])
    max = randomArray[i];

    razn = max - min;
}
Console.WriteLine($"Разница между максимальным и минимальным значением: {razn}");

void ArrayRandomNumbers(double[] randomArray)
{

for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().NextDouble();
    }
}

void PrintArray(double[] randomArray)
{
    for(int i = 0; i < size; i++)
    {
        Console.Write(randomArray[i] + " ");
    }
    Console.WriteLine();
}