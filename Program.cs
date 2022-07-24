/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длинакоторых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

//string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] array = new string[] { "1234", "1567", "-2", "computer science" };
//string[] array = new string[] { "Russia", "Denmark", "Kazan" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); // выводим заданный массив
    }
    Console.WriteLine();
}
void Formation(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) // Убираем слова размером больше трёх симвлов
        {
            arr[i] = arr[i];
        }
        else arr[i] = string.Empty;
    }
}
PrintArray(array);
Formation(array);
Console.Write("Итог: ");
PrintArray(array);


