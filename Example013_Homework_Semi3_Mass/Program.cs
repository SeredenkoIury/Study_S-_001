// СЕРЕДЕНКО ЮРИЙ ДАНИЛОВИЧ
// ДОМАШНЕЕ ЗАДАНИЕ Урок 3. Массивы

//===========================================================================================01
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





//===========================================================================================02
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






//===========================================================================================03
// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
//
// Console.Clear();
// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().NextDouble() + new Random().Next(0, 5);  
//     string result = string.Format("{0:0.00}", array[i]);  
//     Console.Write(result + " | ");  
// }


// double max = array[0];  
// double min = array[0];  
// for (int i = 0; i < array.Length; i++)  
// {
//     if (array[i] > max) 
//     {
//         max = array[i];  
//     }

//     if (array[i] < min) 
//     {
//         min = array[i];  
//     }
// }

// Console.WriteLine();
// string maxi = string.Format("{0:0.00}", max);  
// Console.WriteLine();
// Console.WriteLine("Max is " + maxi);  
// string mini = string.Format("{0:0.00}", min);  
// Console.WriteLine();
// Console.WriteLine("Max is " + mini);  
// double diff = max - min;  
// string result2 = string.Format("{0:0.00}", diff);  
// Console.WriteLine();
// Console.WriteLine("Разница " + result2);  





//===========================================================================================04
// // Задача 4: Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.
//-------------------------------

// Console.Clear();
// Console.WriteLine("Add your number between 1 and 100000 and press ENTER");  
// int nmbr = Convert.ToInt32(Console.ReadLine());  

// int smbls = 0; // how much symbols the number have
// int tempNum = nmbr;  

// while (tempNum != 0) // finding nums
// {
//     tempNum = tempNum / 10;  
//     smbls++;  
// }

// int[] array = new int[smbls]; 
// int[] array2 = new int[smbls]; 

// tempNum = nmbr; 

// if (nmbr > 1 && nmbr < 100000)  
// {
//     for (int i = 0; i < smbls; i++)  
//     {
//         array[i] = tempNum %10;  
//         tempNum = tempNum / 10; 
//     }
//     for(int i =0; i<smbls; i++) 
//       {
//         array2[i] =array[smbls-1-i];
//         Console.Write(array2[i] + " | ");  
//       }
// }
// else  
// {
//     Console.WriteLine("This is not a number between 1 and 100000"); 
// }