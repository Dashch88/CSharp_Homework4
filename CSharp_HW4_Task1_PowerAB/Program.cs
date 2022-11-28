// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowAB(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.Clear();

Console.Write("Введите целое число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительное число B: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine();

if (numB < 0)
{
    Console.WriteLine("Введена не натуральная степень B.");
}
else
{
    Console.WriteLine("Возведение числа A в степень B равно: " + PowAB(numA, numB));
}