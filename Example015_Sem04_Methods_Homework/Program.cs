// === SEREDENKO IURY DANILOVICH SEM04 FROM 11.12.2023 HOMEWORK ================

// Задача 1 ========================================================================TASK 01
// Напишите программу, которая бесконечно запрашивает целые числа 
// с консоли. Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.
//-----------------------------------------------------------------

// Console.Clear();
// Console.WriteLine("Add the number or 'q' to full stop and press ENTER");
// while (true)
// {
//     string text = Console.ReadLine();
//     Console.Clear();

//     //Program full stop ---------------------------------------------\\
//     if (text == "q") break;
//     if (text == "Q") break;
//     if (text == "й") break;
//     if (text == "Й") break;
//     //Program full stop ---------------------------------------------//


//     int number;
//     if (int.TryParse(text, out number)) // checkout if thats tne numbers
//     {
//         Console.WriteLine("Number is " + number);
//         // calculateing the sum
//         int sum = 0;
//         while (number > 0)
//         {
//             sum = sum + number % 10;
//             number = number / 10;
//         }
//         // sum/2 checkout----------------------------------
//         if (sum % 2 == 0)
//         {
//             Console.WriteLine("the sum of parts of Number is even, sooo...");
//             break;
//         }

//         else
//         {
//             Console.WriteLine("Number's ok");
//             Console.WriteLine("Add one more number or q to stop and press ENTER");
//         }
//     }

//     else // if there is no numbers or q
//         Console.WriteLine("Incorrect enter. Please add the number or the Q and Press Enter");
// }
// Console.WriteLine("  //  //  //  //  FULL STOP  // //  //  // ");



// Задача 2 ========================================================================TASK 02
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных
// чисел в массиве.

// void InputArray(int[] array)// Makeing the random array with 3 symbls in 1 point

// {
//     for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100,999);
// }

// bool Check2Times(int x) //returning true if the number % 2 = 0
// {
//          if (x % 2 == 0) return true;
//          return false;
// }

// void ReleaseArray(int [] array) // Haveing the number of points/2
// {
//     int count  = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if  (Check2Times(array [i]) == true)
//             count ++;
//     }
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.WriteLine("Add the number of elements in the Array and press ENTER");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(" | ", array));
// ReleaseArray(array);




// Задача 3 ========================================================================TASK 03
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.).

// Console.Clear();

// void InputArray(int[] array)// Makeing the random array

// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 10);
// }

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void SortingUpSideDown(int[] arr)
// {

//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int memory;
//         memory = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = memory;
//     }

// }

// Console.Clear();
// Console.WriteLine("Add the number of elements in the Array and press ENTER");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// int[] arr = new int[n];
// InputArray(arr);
// PrintArray(arr);
// SortingUpSideDown(arr);
// PrintArray(arr);
