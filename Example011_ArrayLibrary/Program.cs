// Имеется одномерный массив array из n элементовю Требуется найти элемент массива, равный find.
void FillArray(int[] collection)               // Метод заполнения массива collection 
{                                              // случайными числами от 1 до 10   
    int length = collection.Length;            // void - т.к. не выдается никакой результат
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)                     // Метод выдачи полученного массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)        // Метод определения индекса искомого элемента в массиве
{                                              // тут нет void, т.к. выдается некий результат
    int count = collection.Length;
    int index = 0;
    int position = -1;                          // будет выдаваться для несуществующич в массиве значений
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];    // создай новый массив из 10 элементов. Изначально будут нули.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);
