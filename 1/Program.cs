Console.WriteLine("Введите первое число");
string number_1 = Console.ReadLine() ?? "";
int number_1i;
Console.WriteLine("Введите второе число");
string number_2 = Console.ReadLine() ?? "";
int number_2i;

if (int.TryParse(number_1, out number_1i))
{
    if (int.TryParse(number_2, out number_2i))
    {
        if (number_1i > number_2i)
        {
            Console.Write("Максимальное число = ");
            Console.Write(number_1i);
        }
        else
        {
            Console.Write("Максимальное число = ");
            Console.Write(number_2i);
        }
    }
        else
    {
        Console.WriteLine("Ошибка, введите число!");
    }
}
else
{
    Console.WriteLine("Ошибка, введите число!");
}
