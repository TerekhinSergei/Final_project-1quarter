// Написать программу, которая из имеющегося массива из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string[] startArray = Console.ReadLine()!.Split(" ");

string[] resultArray = new string[GetLength(startArray, 3)]; // где 3 - заданна максимальная длина элемента массива
resultArray = ReturnNewArray(startArray, 3);

Console.WriteLine("исходный массив:");
PrintArray(startArray);
Console.WriteLine("итоговый массив:");
PrintArray(resultArray);


int GetLength(string[] array, int n) // где n - заданное условие для длины элемента массива
{
    int leng = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
            leng++;
    }
    return leng;
}

string[] ReturnNewArray(string[] startArray, int n) // где n - заданное условие для длины элемента массива
{
    int j = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= n)
        {
            resultArray[j] = startArray[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    if (count == 0)
        Console.Write("[] , нет элементов соответсвующих условию!");
    else
    {
        Console.Write("[");
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i]);
            if (i == count - 1)
                Console.WriteLine("]");
            else
                Console.Write(", ");
        }
    }
}
