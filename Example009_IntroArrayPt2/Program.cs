int[] array = { 11, 52, 83, 49, 65, 69, 73, 4 };

int n = array.Length; //info about how much elements
int find = 73;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
        index++; //index = index + 1;
}