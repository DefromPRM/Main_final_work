﻿// Задача алгоритмически не самая сложная, 
// однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма 
// (можно обойтись блок-схемой основной содержательной части, 
// если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения 
// (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так, что всё залито одним коммитом, 
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[7] { "1185", "12", "484", "27", "942", "7", "65843" };
string[] array1 = new string[array.Length];

void NewArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + "   ");
    }
    Console.WriteLine();
}
NewArray(array, array1);
PrintArray(array1);
