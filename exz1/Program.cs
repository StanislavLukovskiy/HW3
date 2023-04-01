// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int x = ReadInt("Введите число ");
int a1 = x % 10;//1
int a2 = x / 10 % 10;//2
int a3 = x / 100 % 10;//8
int a4 = x / 1000 % 10;//2
int a5 = x / 10000;//1
int x1 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
System.Console.WriteLine(x1);
if (x == x1)
{
    System.Console.WriteLine($"да");
}
else
{
    System.Console.WriteLine($"нет");
}