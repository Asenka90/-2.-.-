// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо рано три символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Пример: ["hello", "2", "world" ,":-)"]=>["2", ":-)"]

string[] array1 = new string[4] {"hello", "2", "world" ,":-)"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array1, array2);
PrintArray(array2);