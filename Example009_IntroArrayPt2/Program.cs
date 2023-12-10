int[] array = { 11, 52, 83, 49, 7, 65, 7, 73, 4 };

int n = array.Length; //info about how much elements
int find = 7;

int index = 0;

Console.Clear(); 

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Programm Full Stop
    }
        index++; //index = index + 1;
}