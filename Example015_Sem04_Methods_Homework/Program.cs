// === SEREDENKO IURY DANILOVICH SEM04 FROM 11.12.2023 HOMEWORK ================

// Задача 1 ========================================================================TASK 01
// Напишите программу, которая бесконечно запрашивает целые числа 
// с консоли. Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.

// bool S1(int n) //returning true if should start full stop
// {

//          if (n == q) return true;
//          return false;
// }


Console.Clear();
Console.WriteLine("Add the number or q to stop the programm and press ENTER");
while (true)
{
    
    string text = Console.ReadLine();
    Console.Clear();
    //Program full stop ----------------------------------------\\
    if (text == "q")
    {
    Console.WriteLine("  //  //  //  //  FULL STOP  // //  //  // ");
    break;
    }
    if (text == "Q")
    {
    Console.WriteLine("  //  //  //  //  FULL STOP  // //  //  // ");
    break;
    }
    if (text == "й")
    {
    Console.WriteLine(" //  //  //  //  FULL STOP  // //  //  // ");
    break;
    }
    if (text == "Й")
    {
    Console.WriteLine("  //  //  //  //  FULL STOP  // //  //  // ");
    break;
    }
    //Program full stop ----------------------------------------//


    int number;
    if (int.TryParse(text, out number)) // Проверка, является ли ввод числом{
        {
            Console.WriteLine("Number is " + number);
            // calculateing the sum
             int sum = 0;
             while (number > 0)
             {
                sum = sum + number % 10;
                number = number / 10;
             }

            // sum/2 checkout----------------------------------
            if (sum % 2 == 0)
             {
             Console.WriteLine("the sum of parts of Number is even, sooo...");
             Console.WriteLine("  //  //  //  //  FULL STOP  // //  //  // ");
             break;
             }


            else  
            {
            
            Console.WriteLine("Number's ok");
            Console.WriteLine("Add one more number or q to stop and press ENTER");
            }
        }

    else // Если ввод не является числом и не 'q', повторить запрос
    Console.WriteLine("Incorrect enter. Please add the number or the Q and Press Enter");
    
}








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
