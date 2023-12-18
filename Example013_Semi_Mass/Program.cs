///// Seminar 03, MASS

Console.Clear();
Console.WriteLine("Add the number of the ellements in array and press ENTER");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];// целые числа[массив] названиемассива = новый изцелыхчисел[колличество элементов];

for (int i = 0; i < array.Length; i++) // array.Length = n-1;
{
    array[i] = new Random().Next(0,11); //[0,10]
}

Console.Write("|");

for (int i = 0; i < array.Length; i++) 
{
    Console.Write(" " + array[i] + " | "); 
}

