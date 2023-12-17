// //Семинар 2, задача 1:Напишите программу, которая принимает на вход число и 
// //проверяет, кратно ли оно одновременно 7 и 23.
// Console.Clear();
// Console.WriteLine("Add the number and press ENTER");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n / 23 == 7 && n / 7 == 23)
//     Console.WriteLine("Yes, Number " + n + " is multiply of both 7 and 23");
// else
//     Console.WriteLine("No, Number " + n + " is not multiply of both 7 and 23");



// Задача 2, задача 2 : Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти
// плоскости, в которой находится эта точка.
// Console.Clear();
// Console.WriteLine("Add the number and press ENTER");
// Console.WriteLine("Add X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Add Y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// Console.Write("XY [" + x + ", " + y + "] - on the PART ");

// if (x > 0 && y > 0)Console.WriteLine("1");
// if (x < 0 && y > 0)Console.WriteLine("2");
// if (x < 0 && y < 0)Console.WriteLine("3");
// if (x > 0 && y < 0)Console.WriteLine("4");
// if (x > 0 && y == 0)Console.WriteLine("1-2 on line ");
// if (x < 0 && y == 0)Console.WriteLine("3-4");
// if (x == 0 && y > 0)Console.WriteLine("1-4");
// if (x == 0 && y < 0)Console.WriteLine("3-2");
// if (x == 0 && y == 0) Console.WriteLine("Part 0-0");






// // Задача 3: Напишите программу, которая принимает на вход целое число из 
// // отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear(); 
Console.WriteLine("Add the number between 10 and 99");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 10;
int n2 = n % 10;


if (n > 9 && n < 100)
{
Console.Write("The highest symbol of the " + n + " is ");

// if (n1 < n2)
//     Console.WriteLine(n2);
// else
//     Console.WriteLine(n1);
// }
// else 
// {
//     Console.WriteLine("This is not a number between 10 and 99!");
// }


//Задача 4: Напишите программу, которая на вход принимает натуральное 
//число N, а на выходе показывает его цифры через запятую.
Console.Clear();
Console.WriteLine("Введите натуральное число и нажмите ENTER");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int numbers = N % 10;
        N = N / 10;
        if (N > 0) Console.Write(numbers  + ", ");
        else  Console.Write(numbers);
    }
}




