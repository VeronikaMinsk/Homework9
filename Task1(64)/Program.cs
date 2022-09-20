// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Enter M: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int last = Convert.ToInt32(Console.ReadLine());

numbersRow(first, last);

int numbersRow(int m, int n)
{
	if (m > n) 
        return n;
	else
	{
		Console.Write(m + " ");
		m++;
	}
	return numbersRow(m, n);
}




