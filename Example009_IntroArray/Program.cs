int Max(int arg1, int arg2, int arg3) //similar like x, y, z
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//               0   1   2   3   4   5  6   7   8
int[] array = { 11, 22, 33, 24, 56, 66, 7, 89, 129 };
//array [0] = 12;
//Console.WriteLine(array[4]);

int max = Max(  
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6],array[7],array[8]));

Console.Clear();
Console.Write("The max number of the array is ");
Console.WriteLine(max);