// запишите программу которая принимает на вход три числа и выдает максимальное из этих чисел 

Console.WriteLine("Введите первое число ");
string input1 = Console.ReadLine()!;
int num1int = int.Parse(input1);

Console.WriteLine("Введите второе число ");
string input2 = Console.ReadLine()!;
int num2int = int.Parse(input2);

Console.WriteLine("Введите второе число ");
string input3 = Console.ReadLine()!;
int num3int = int.Parse(input3);
if (num1int > num2int)
{
    if (num1int > num3int)
    {
        Console.WriteLine (num1int + "самое большое число");
    }
    else 
    {
        Console.WriteLine (num3int + "самое большое число");
    }
}
else
{
    if (num2int > num3int)
    {
        Console.WriteLine (num2int + "самое большое число");
    }
    else
    {
        Console.WriteLine (num3int + "самое большое число");
    }
}