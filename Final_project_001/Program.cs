// ЗАДАЧА:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Метод выборки строк в массиве, длиной не более 3х символов
void SortStringArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}


// Метод печати массива строк
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//Основная программа

// Инициализация массивов
string[] array1 = new string[10] { "46", "sfdf", "ffg", "dhfjdfd", "world_of_tanks", "111", "pi", "var", "lib", "string"}; // Массив строк для анализа
string[] array2 = new string[array1.Length]; // Результирующий массив

SortStringArr(array1, array2);
PrintArray(array2);