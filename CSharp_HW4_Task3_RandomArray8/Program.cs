// Задача 29: Напишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]

Console.Clear();

int[] randomArray = new int[8];

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0, 21);
    Console.Write(randomArray[i] + " ");
}
Console.WriteLine();