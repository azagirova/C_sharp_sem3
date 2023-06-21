/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int xA = InputNum("Введите координату xA: ");
int yA = InputNum("Введите координату yA: ");
int zA = InputNum("Введите координату zA: ");
int yB = InputNum("Введите координату xB: ");
int xB = InputNum("Введите координату yB: ");
int zB = InputNum("Введите координату zB: ");

double Root(double xA, double yA, double zA, double xB, double yB, double zB)
{

    return Math.Sqrt(Math.Pow((xB - xA), 2) +
    Math.Pow((yB - yA), 2) +
    Math.Pow((zB - zA), 2));

}

double distance = Root(xA, yA, zA, xB, yB, zB);

Console.WriteLine(Math.Round(distance, 2));
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num = InputNum("Введите число: ");

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i < num)
        {
        Console.Write(", ");
        }
    else
        {
        Console.Write(".");
        }
}
