﻿// // Урок 3. Массивы
// // Сдавать ссылкой на GITHUB(отправить в комментарии к дз)



// // Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// // Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Console.Clear();
// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++) //makeing the random array
// {
//     array[i] = new Random().Next(0,101); //[0,100]
// }

// Console.WriteLine("Your random array is");
// Console.WriteLine(string.Join(" | ", array));

// int answer = 0;
// for(int i = 0; i < array.Length; i++)
//     if (array[i] > 19 && array[i] < 91)
//         answer ++;
// Console.WriteLine("There is " + answer + " numbers between 20 and 90 in the array");






// // Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая
// // определяет количество чётных чисел в массиве.

// Console.Clear();
// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++) //makeing the random array
// {
//     array[i] = new Random().Next(0,101); //[0,100]
// }

// Console.WriteLine("Your random array is");
// Console.WriteLine(string.Join(" | ", array));

// int answer = 0;
// for(int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
//         answer ++;
// Console.WriteLine("There is " + answer + " numbers that can be divisible by 2");







// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Console.Clear();
// double[] array = new double[10];

// for (int i = 0; i < array.Length; i++) //makeing the random array
// {
//     array[i] = new Random().Next(0.0,10.0); //[0,100]
// }

// Console.WriteLine("Your random array is");
// Console.WriteLine(string.Join(" | ", array));

// int answer = 0;
// for(int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
//         answer ++;
// Console.WriteLine("There is " + answer + " numbers that can be divisible by 2");




// // Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.

int n = new Random().Next(1;100000);
Console.WriteLine(n)
