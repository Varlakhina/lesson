
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;

if (number1 == square) Console.WriteLine($"число {number2} является квадратом числа {number1}");
else
{
    Console.WriteLine($"число {number2} не является квадратом числа {number1}");
}
