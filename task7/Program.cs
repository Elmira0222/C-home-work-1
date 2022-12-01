/* Напишите программу, которая принимает на вход трёхзначное число и на выходе
 показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8 */

Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine()!);

if (N > 99 & N < 1000){
    Console.WriteLine(N%10);
} else {
    Console.Write ("It is not three digit number");
}

