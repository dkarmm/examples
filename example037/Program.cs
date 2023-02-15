// 37. В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

void addNumbers(int[] array) // Функция добавления в массив рандом чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}
void showRandomNumbers(int[] array) // Функция показа этих чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

int [] array = new int [123];

addNumbers(array);
showRandomNumbers(array);