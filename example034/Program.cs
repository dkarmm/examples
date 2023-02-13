//  34. Написать программу замену элементов массива на противоположные

Console.Clear();

void addNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
}

void printNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

void mirrorNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = array[index] * -1;
        Console.Write(array[index] + " ");
        index++;
    }
}

Console.Write("Введите размер массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lengthArray];
Console.Clear();
if (lengthArray == 0)
{
    Console.WriteLine("Ошибка. Массив должен содержать минимум 1 число.");
    return;
}

addNumbers(array);
Console.WriteLine("Числа в массиве: ");
printNumbers(array);
Console.WriteLine();
Console.WriteLine("Отражение чисел массива: ");
mirrorNumbers(array);
Console.WriteLine();