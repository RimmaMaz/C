// на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число...");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    Console.Write($"{a}-");
    Console.WriteLine("четное");
}

else
{
    Console.Write($"{a}-");
    Console.WriteLine("не является четным");
}







