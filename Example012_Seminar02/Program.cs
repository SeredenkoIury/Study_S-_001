// // // задача 01. --------------------------------------------------------------------------
// // // Напишите задачу, которая принимает на вход
// // // трехзначное число и удаляет вторую цифру этого числа.
// // // примеры
// // // a = 256 => 26
// // // a = 891 => 81

// Console.Clear();
// int n = new Random().Next(100, 1000);
// Console.WriteLine("Random number is " + n);
// int n1 = n / 100;
// int n2 = n % 10;
// int n3 = (n1 * 10) + n2;

// Console.WriteLine("The number of 1st and the 3rd symbols is " + n3);
// // ----------------------------------------------------------------------------------


// Задача 02 -----------------------------------------------------------------
// Напишите задачу, которая на вход будет принимать два числа,
// и выводить, является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.
// Примеры: 
// 14, 5 => нет, 4
// 4, 3 => нет, 1
// 16, 8 => да // 16 % 8 = 

// Console.WriteLine("Add the First number and press ENTER");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Add the Second number and press ENTER");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 % n2 ==0 )
// {
//     Console.WriteLine("Yes");
// }
// else 
// {
//     Console.WriteLine("No, " + n1 % n2);
// }
//-------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход трехзначное число и 
// возводит вторую цифру этого числа в степень, равную третьей цифре
// пример
// 487 => 8^7 = 625

// Console.Clear();
// int n = new Random().Next(100, 1000);
// Console.WriteLine("Random number is " + n);

// //int n1 = n % 10;
// int n2 = n /10 % 10 ;
// int n3 = n % 10;

// Console.WriteLine(n2);
// Console.WriteLine(n3);
// int result = 1;
// for (int i = 0; i < n3; i++)
//     //s  = s * n2;
//     result *= n2;

// Console.WriteLine(result);
//--------------------------------------------------------------------------
// Напишите программу, которая выводит третью с конца  
// цифру заданного числа или сообщает что такой цифры нет.
// пример
// 487 => 4
// 2346 => 3
// 98 => третье цифры нет.

Console.WriteLine("Add the First number and press ENTER");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("There is no third.");
}
else
{
    while (n > 999)
    {
        n /= 10;
    }
    Console.WriteLine(n % 10);
}

