int numberA = new Random().Next(1, 100); // случайное число 1 2 3 ... 9
Console.Write("First  number is "); // выводим в консоль число А
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100); // случайное число 1 2 3 ... 9
Console.Write("Second number is "); // Выводим в консоль число B
Console.WriteLine(numberB);

// через доп переменную суммируем
int result = numberA + numberB;

// Выводим сумму
Console.Write("The summ is ");
Console.WriteLine(result);

