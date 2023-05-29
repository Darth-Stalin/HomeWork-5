// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int sum = 0;
int rev;
Console.WriteLine("Введите пятизначное число ");
int Number = int.Parse(Console.ReadLine());
if (Number < 100000 && Number > 9999)
{
    for(rev=Number; Number!=0; Number = Number / 10)
{
    int a = Number % 10;
    sum = sum * 10 + a;
}
    if(rev==sum)
        Console.WriteLine($"{rev} является палиндромом");
    else
    Console.WriteLine($"{rev} не является палиндромом");
} 
else
Console.WriteLine("Это не пятизначное число");
