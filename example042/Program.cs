// 42. Определить сколько чисел больше 0 введено с клавиатуры

void AddNumbersInArray(int [] array)
{
    int position = 1;
    for (int index = 0; index < array.Length; index++)
    {
        Console.Clear();
        Console.Write($"Введите {position} число: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        position++;
    }
}

void ShowArray(int [] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
}

int ShowResult (int [] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

AddNumbersInArray(array);
ShowArray(array);

Console.WriteLine();

int result = ShowResult(array);
Console.Clear();
Console.WriteLine($"Количество чисел больше нуля: {result}.");

