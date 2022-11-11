// while
// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

//Console.WriteLine("Введите число N: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int count = -n;
//while (count <= n)
//{
//    Console.Write($"{count} ");
//    count++;
//}

//if (number1 > 0);
//else
//{
//    Console.WriteLine("неверное число");
//}


Console.WriteLine("введите целое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = -number1;

if (number1 > 0)
{
while (number2 <= number1)
{
    Console.WriteLine($"{number2}");
    number2 += 1;
}
}
else
{
Console.WriteLine("неверное число");
}