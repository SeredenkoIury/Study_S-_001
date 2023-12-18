Console.Clear();

// // version 1 ====================================================
// void Method1() 
// {
//     Console.WriteLine("Message m1");
//    // doing something, writing something
//     // have the name and body, no arguments or ect
// }

// Method1(); // - calling the Method1 


// // version 2 ===================================================
// void Method2(string msg) 
// {
//     Console.WriteLine(msg);
//     //useing some operators  and using some arguments
//     // have the name and body, can have arguments or ect
// }
// Method2("Message m2"); // - calling the Method1 

// //-----

// void Method21(string msg, int count) 
// {

//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
//     //useing some operators  and using some arguments
//     // have the name and body, can have arguments or ect
// }
// Method21("message text m2.2", 4); // - calling the Method1 

// // version 3 ===================================================
// int Method4() 
// {
//     return DateTime.Now.Year;
//      // have the name useing type, and body, gives smthng
// }
// int year = Method3(); // - calling the Method1 
// Console.WriteLine(year);

// // version 4 ===================================================
// string Method4(int count, string c) 
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//         {
//             result = result + c;
//             i++;
//         }
//     return result;
//     // have the name,  useing the type, have a body, using some arguments, returning smthng
// }
// string res = Method4(10, "love it? ");
// Console.WriteLine(res);

// // version 4 with "for"===================================================
// string Method4(int count, string c) 
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//        result = result + c;
//     return result;
//     // have the name,  useing the type, have a body, using some arguments, returning smthng
// }
// string res = Method4(10, "love it? ");
// Console.WriteLine(res);
// Console.Clear();
// for (int i = 2; i<=10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//       {
//          Console.WriteLine($"{i} x {j} = {i * j}");

//       }
//       Console.WriteLine();
// }
// //================================================task 01================================
// Дан текст. В тексте нужно все пробелы заменить на черточки, маленькие 
// буквы к заменить большими К, а польшие С заменить маленькими с.
//--------------------

// string text = " - Я думаю, - Сказал князь, улыбаясь, - что, "
//             + "ежели бы ваС послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            0123
// // s[3]  // r

// Console.Clear();

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else   result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();
//------------------------------

// =========================================================================Mass Sorting 
// Найти позицию минимального элемента в неотсортированной части массива
// произвести обмен этого значения со значением первой неотсортированной позиции
// повторять пока есть неотсортированные элементы
//------------------

// Console.Clear();
// int[] arr = { 1, 4, 2, 5, 3, 6, 2, 3, 4, 9 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length - 1; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
//------------------------------------------------------------


//=====================================================================Homework Funct Lect
// Homework
//переделать код так чтобы упорядочивание было не от 0 до + а от + до 0
//  void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length - 1; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
//--------------------------------