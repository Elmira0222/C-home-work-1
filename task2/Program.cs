/* Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine()!);

if (b > a)
{
    Console.WriteLine("answer : max");
    Console.Write(b);
}
if (a > b)
{
    Console.Write("answer : max");
    Console.Write(a);
}


