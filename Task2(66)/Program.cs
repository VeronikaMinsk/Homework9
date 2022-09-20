// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите первое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число N:");
int n = Convert.ToInt32(Console.ReadLine());

NumberSumm(m, n, 0);
void NumberSumm (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSumm(m, n, sum);
}


