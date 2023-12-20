//============= Semi 04 Methods from 11.12,2023 =========================================
Console.Clear();

// //Procedure ex 01 ----------------------------------

// void p1(int x) // procedure named p1, on enter have x
// {              // will write entered x on console
//     Console.WriteLine("Procedure p1. " + x);
//     // procedure will make whatever we want only when we will use it
// }              // it will not work by itself

// p1(5); //useing/calling void p1, entereing 5
// p1(3); //useing/calling void p1, entereing 5
//        // 5 and 3 are the arguments

// //Procedure ex 02----------------------------------
// void p2(int a, int b)
// {
//     if (a > b) Console.WriteLine("Procedure p2. " + "From " + a + " and " + b + ". Max is " + a);
//     if (b > a) Console.WriteLine("Procedure p2. " + "From " + a + " and " + b + ". Max is " + b);
//     //else Console.WriteLine("void p2. " + a + " and " + b + " is similar numbers"); // not working propparly
//     //!should means that a = b, but with p2(99,64) writing as similar. 
//     if (b == a) Console.WriteLine("Procedure p2. " + a + " and " + b + " is similar numbers");
// }
// p2(5, 7); //calling void p2, entering 5 and 7
// p2(99, 64); // 5 and 7, 99 and 64, 40 and 40 
// p2(40, 40); // are the arguments

// //Procedure ex 03----------------------------------
// void p3(int m)
// {
//     Console.WriteLine("Procedure p3. " + m);
//     m = m + 1;
//     Console.WriteLine("Procedure p3. " + m);
// }

// int m = 5;
// p3(m);
// Console.WriteLine(m);

// //Procedure ex 04----------------------------------
// void p4(ref int n)
// {
//     Console.WriteLine("Procedure p4. " + n);
//     n = n + 1;
//     Console.WriteLine("Procedure p4. " + n);
// }

// int n = 5;
// p4(ref n);
// Console.WriteLine(n);





// //Function ex 01----------------------------------
// int f1(int a, int b) // function of the int data type named f1, on enter have a and b,
// {             // will return the maximum from entered a and b on the call sector.
//               // If we want to return int we will write int f1(), if we want to return the
//               //mass we will write int[] f1(), if we want to return the string, we will
//               //write string f1() and ect
//     if (a > b)
//         return a; // will return a as max from a and b and will stop function circle
//     else
//         return b; // will return b as max from a and b and will stop function circle
//                   // function will make whatever we want for return only when we will use/call it
// }             // it will not work by itself

// int x1 = f1(5, 8);  //makeing int x1 = useing/calling int f1, entereing 5 and 8
// Console.WriteLine("Function f1. " + ". Max is " + x1);
// // 5 and 8 are the arguments
// int x2 = f1(16, 13); //makeing int x2 = useing/calling int f1, entereing 16 and 13
// Console.WriteLine("Function f1. " + ". Max is " + x2);
// // 16 and 13 are the arguments

// //Function ex 02----------------------------------
// int f2(int a, int b)
// {
//     if (a > b) return a;
//     else return b;
// }
// Console.WriteLine("Function f2. " + ". Max is " + f2(92, 75)); // alternative console writing without x
//                                                                // actially f2(92,75) = 92 on our version

// //Function ex 02----------------------------------
// int f3(int a, int b)
// {
//     if (a > b) return a; // in case of return means full stop for function,
//     return b;            // sometimes we can delete else 
//     Console.WriteLine("!!");
// }
// Console.WriteLine("Function f3. " + ". Max is " + f3(33, 15));

//================================================================================= Task 01
// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.
// пример
// [1 3 4 19 3] => 2
// [ 4 3 4 1 9 5 21 13] => 3
//------------------------------------------

void InputArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,20);
}

bool CheckSimple(int x)//returning true if the number is simple
{
    for (int j = 2; j < x; j++)
        {
         if (x % j == 0) return false;
        }
    return true;
}

void ReleaseArray(int [] array)
{
    int count  = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if  (CheckSimple(array [i]) == true)
            count ++;
    }
    Console.WriteLine(count);
}

Console.Clear();
Console.WriteLine("Add the number of elements in the Array and press ENTER");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(" | ", array));
ReleaseArray(array);


