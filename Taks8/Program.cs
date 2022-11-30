// напишите программу, которая на входе принимает число N, а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите целое число ");
string num1 = Console.ReadLine()!;
int num1int = int.Parse(num1);

if (int i = 1 ; i <= num1int ; i++)
{
    if (num1 % 2 == 0)
    {
        Console.WriteLine(num1 + "четное число");
    }
}