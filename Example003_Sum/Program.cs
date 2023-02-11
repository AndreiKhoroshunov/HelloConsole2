// 3_3 programm
int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine("первое число: ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine("второе число: ");
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine("Сумма: ");
Console.Write(result);