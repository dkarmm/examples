// 31. Задать массив из 8 элементов и вывести их на экран 
Console.Clear();

void addNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1,10);
        index++;
    }
}
void showNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
int [] array = new int [8];
addNumbers(array);
showNumbers(array);
Console.WriteLine();