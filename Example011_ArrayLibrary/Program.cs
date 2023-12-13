void FillArray(int[] collection)
{
    int length = collection.Length; //adding and array
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //adding a random number between 1 and 10
        index++; //index = index + 1; 
    }


}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write("|");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {

        if (collection [index] == find)
        {
            position = index;
            break; //Programm Full Stop
        }
        
        index++;
    }
    return position;
}

int[] array = new int[10]; //Указание, что по умолчанию в массиве будет 10 элементов


Console.Clear();
Console.WriteLine();
Console.WriteLine("----Random Array----");
FillArray(array);
array[5] = 4;
array[9] = 4;
PrintArray(array);
Console.WriteLine();
Console.WriteLine("----Random Array----");
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
