﻿// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите желаемое количество чисел через пробел: ");


int[] InputData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] GetArray(int size, int minValue, int maxValue) // Функция создания массива
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random(). Next(minValue, maxValue + 1);
    }
    return res;

}

int countPos = 0;

int size = InputData.Length;

for (int i = 0; i < size; i++)
{
    if (InputData[i] > 0)
    {
        countPos ++;
    }
}
if (countPos == 0) Console.WriteLine($"Чисел больше 0 нет."); 

if (countPos == size) Console.WriteLine($"Все {size} больше 0 "); 

if (countPos != 0 && countPos != size) Console.WriteLine($"В введённом ряду {countPos} чисел больше 0.");
