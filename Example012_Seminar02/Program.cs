// задача 01.
// Напишите задачу, которая принимает на вход
// трехзначное число и удаляет вторую цифру этого числа.
// примеры
// a = 256 => 26
// a = 891 => 81

Console.Clear();
int n = new Random ().Next(100, 1000); // генерация рандомного числа трехзначного
                                       // функция next включает первое число но не 
                                       включает последнее, поэтому 1000 а не 999


int a = n/100;
int b = n%10;

Console.WriteLine("Randon Nimbwr is " + n);
Console.Write("1st and 3rd symb together is " + a);
Console.WriteLine(b);
