// Console.Clear();
// Console.WriteLine("Specify the number and press ENTER");
// int s = Convert.ToInt32(Console.ReadLine());
// //s = "5"
// Console.Clear();
// Console.Write("Answer is ");
// Console.WriteLine(s + 5);

// // Maked a visuality decision of the end of the program\
// Console.WriteLine(" ");
// Console.WriteLine("----/Х/----/Х/- Program finished -/Х/----/Х/----");
// Console.WriteLine(" ");

//-------------------------------------------------------------------------------------------------------
// Напишите программу которая на вход принимает два целых числа и проверяет, является ли
// первое число квадратом второго.
// a = 25, b = 5 => yes;
// a = 2, b = 10 => no
// a = , b = -3  => yes
// a = , b = 9  => no

// Console.Clear(); // consol cleaning before start
// Console.WriteLine("Specify the A number and press ENTER");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Clear(); // consol cleaning after specifying
// Console.WriteLine("Specify the B number and press ENTER");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Clear(); // consol cleaning after specifying

// Console.Write("Number A is ");
// Console.WriteLine(a);
// Console.Write("Number B is ");
// Console.WriteLine(b);

// if (a == b * b)
//     { 
//         Console.Write("Number A is the square of the number B, the answer is YES");
//     }
// else  
//     {
//         Console.WriteLine("Number A is not the square of the number B, the answer is NO");
//     }
// //-------------------------------------------------------------------------------------------------------


//-------------------------------------------------------------------------------------------------------
// Напишите программу, которая на входе принимает целое число N, а на выходе показывает 
// все целые числа в промежудке от -N до N
// примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Clear(); //console cleaning before start
Console.WriteLine("Specify the A number and press ENTER");
int a = Convert.ToInt32(Console.ReadLine());
int count = a * (-1);

while (count <= a)
    {
    Console.Write( count + " |");
    count = count + 1;
    }
//-------------------------------------------------------------------------------------------------------