Console.WriteLine("Введите первое число");
string number_1 = Console.ReadLine() ?? "";
int number_1i;
Console.WriteLine("Введите второе число");
string number_2 = Console.ReadLine() ?? "";
int number_2i;
Console.WriteLine("Введите третье число");
string number_3 = Console.ReadLine() ?? "";
int number_3i;
int max = 0;

if (int.TryParse(number_1, out number_1i))
{
    if (int.TryParse(number_2, out number_2i))
    {
        if (int.TryParse(number_3, out number_3i))
        {
            if (number_1i>max) max = number_1i;
            if (number_2i>max) max = number_2i;
            if (number_3i>max) max = number_3i;
            Console.Write("Максимальное число = ");
            Console.Write(max);
        }
        else
        {
            Console.WriteLine("Ошибка при вводе числа 3, введите число!");
        }
    }
        else
    {
        Console.WriteLine("Ошибка при вводе числа 2, введите число!");
    }
}
else
{
    Console.WriteLine("Ошибка при вводе числа 1, введите число!");
}