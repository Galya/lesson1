// напишите программу, которая на входе принимает два числа и выдает, какое число больше, а какое меньше

Console.WriteLine("Введите первое число ");
string input1 = Console.ReadLine()!;
int input1int = int.Parse(input1);

Console.WriteLine("Введите второе число ");
string input2 = Console.ReadLine()!;
int input2int = int.Parse(input2);

if (input1int > input2int)
{
    Console.WriteLine(input1int + "Больше" + input2int);
}
else if (input2int >input1int)
{
    Console.WriteLine(input2int + "Больше" + input1int);
}
else
{
    Console.WriteLine("числа равны");
}


