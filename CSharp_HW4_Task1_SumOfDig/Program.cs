// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int sumOfDig = 0;

Console.WriteLine();

for (int i = 0; i < str.Length; i++)
{
    if (str[i] != '-' && str[i] != '.' && str[i] != ',')
    {
        sumOfDig = sumOfDig + int.Parse(str[i].ToString());
    }
}

Console.Write("Сумма всех цифр в введённом числе равна: " + sumOfDig);
Console.WriteLine();