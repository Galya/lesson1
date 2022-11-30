// напишите программу где на входе принмает число и выдает, является ли число четным

Console.WriteLine("Введите целое число ");
string input1 = Console.ReadLine()!;
int input1int = int.Parse(input1);

if (input1int % 2 == 0)
{
    Console.WriteLine(input1 + "четное число");
}
else
{
    Console.WriteLine(input1 + "не четное число");
}