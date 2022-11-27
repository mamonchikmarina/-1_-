/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число А: ");
string numberAStr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAStr);

Console.WriteLine("Введите число B: ");
string numberBStr = Console.ReadLine();
int numberB = Convert.ToInt32(numberBStr);

Console.WriteLine("Введите число C: ");
string numberCStr = Console.ReadLine();
int numberC = Convert.ToInt32(numberCStr);

int max = numberA;

if(numberB > max ) max = numberB;
if(numberC > max ) max = numberC;

Console.WriteLine(max);
