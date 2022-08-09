Console.WriteLine("Введите число N:");
string num = Console.ReadLine() ?? "";
int num_i;
int count = 1;

if (int.TryParse(num, out num_i))
{   
    Console.WriteLine("Все чётные числа от 1 до N: ");
    while (count<=num_i)
    {
    if (count % 2 == 0) Console.WriteLine(count);
    count++; 
    }   
}
else
{
    Console.WriteLine("Ошибка при вводе данных, введите число!");
}

