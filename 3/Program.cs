Console.WriteLine("Введите число");
string num = Console.ReadLine() ?? "";
int num_i;

if (int.TryParse(num, out num_i))
{
    if (num_i % 2 == 0) 
    {
        Console.Write("Число ");
        Console.Write(num_i);
        Console.Write(" чётное");
    }   
    else 
    {
        Console.Write("Число ");
        Console.Write(num_i);
        Console.Write(" нечётное");
    }
}
else
{
    Console.WriteLine("Ошибка при вводе данных, введите число!");
}

