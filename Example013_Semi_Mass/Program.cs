///// Seminar 03, MASS

//==========================================================================================01
// // makeing the size with console enter
// Console.Clear();
// Console.WriteLine("Add the number of the ellements in array and press ENTER");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];// целые числа[массив] названиемассива = новый изцелыхчисел[колличество элементов];

// //makeing the random array with our size(n)
// for (int i = 0; i < array.Length; i++) // array.Length = n-1;
// {
//     array[i] = new Random().Next(0,11); //[0,10]
// }

// // writing out the array ex1
// Console.Write("|");
// for (int i = 0; i < array.Length; i++) // a candy
// {
//     Console.Write(" " + array[i] + " |"); 
// }

// //writing out the array ex2 
// Console.WriteLine();
// Console.WriteLine(string.Join(" | ", array)); //(строка.Соединение('разделитель между аргументами', массив))



//==========================================================================================02
// // Задайте массивю Найдите программу, которая определяет, 
// // присутствует ли заданнное число в массиве. Программа должна выдать ответ да/нет.
// // пример:
// // [1 3 4 19 3], 8 => no 
// // [-4 3 4 1], 3 => yes
//---------------------------------
// Console.Clear();
// Console.WriteLine("Add the number of the ellements in the array and press ENTER");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];// целые числа[массив] названиемассива = новый изцелыхчисел[колличество элементов];

// //makeing the random array with our size(n)
// for (int i = 0; i < array.Length; i++) // array.Length = n-1;
// {
//     array[i] = new Random().Next(0,11); //[0,10]
// }

// //writing out the array ex2 
// Console.WriteLine(string.Join(" | ", array)); //(строка.Соединение('разделитель между аргументами', массив))

// Console.WriteLine("Add the sounding number in the array and press ENTER");
// int found = Convert.ToInt32(Console.ReadLine());

// bool flag = false;
// for (int i = 0; i < array.Length; i++)
//     if (array[i] == found)
//     { 
//         Console.WriteLine("YES, There is " + found + " in the array");
//         flag = true;
//         break; // for() Full stop
//     }

// if (flag == false) 
// Console.WriteLine("NO, There is no " + found + " in the array");


// ==========================================================================================03
// Задайте массив из 10 элементовб заполненный числами из промежутка
// [-10, 10]. Замените отридцательные элементы положительными а положительные
// отридцательными.
// пример
// [1,-5,6] => [-1;-5;6]
//---------------------------------------------
// Console.Clear();
// int[] array = new int[10];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10,11);

// Console.WriteLine(string.Join(" | ", array));

// for(int i = 0; i < array.Length; i++)
//     array[i] = array[i] * -1;

// Console.WriteLine(string.Join(" | ", array));

//==========================================================================================04
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и тд. Результат запишите в новый массив.
// пример 
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5], (элемент 7 не имеет пары)
//------------------------------------------------------
// Console.Clear();
// int n = new Random().Next(3, 11);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11);

// Console.WriteLine(string.Join(" | ", array));

// int[] array_new = new int[n / 2];

// for (int i = 0; i < array_new.Length; i++)
//     array_new[i] = array[i] * array[array.Length - 1 - i];

// Console.WriteLine(string.Join(" | ", array_new));


//==========================================================================================05
// Дано натуральное трехзначное число. Создайте массив, состоящий из цифр этого
// числа, Младший разряд числа должен распологаться на 0-м индексе массива,
// старший - на 2м.
// пример 
// 456 => [6 5 4]
// 781 => [1 8 7]
//----------------------------------------------

Console.Clear();
int n = new Random().Next(1, 100000);
Console.WriteLine(n);
int[] array = new int[6];
for (int i = 0; i < 6; i++)
{
    array[i] = n % 10;
    n = n / 10;
}
Console.WriteLine(string.Join(" | ", array));