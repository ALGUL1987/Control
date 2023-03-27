/*
Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введите количество строк n=: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] resultArray = GetArray(n);
int size = GetSize(resultArray);
string[] newArray = ConvertArray(resultArray);
Console.WriteLine($"Исходный массив: [{String.Join(";", resultArray)}]");
Console.WriteLine($"Конвертированный массив: [{String.Join(";", newArray)}]");

string[] GetArray(int size)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите значение строки: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
int GetSize(string[] array)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] ConvertArray(string[] array)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
