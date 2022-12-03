﻿/* Имеется одномерный массив array из n элементов,
требуется найти элемент массива, равный find:
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу успешно
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу успешно 
Для выполнения использовать методы и генератор случайных чисел */

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[10];

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);