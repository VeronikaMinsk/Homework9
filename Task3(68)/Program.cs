// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int m = InputNumber("Введите m: ");
int n = InputNumber("Введите n: ");
Console.WriteLine(AckerFunc(n, m));

int InputNumber(string a)
{
	Console.WriteLine(a);
	return Convert.ToInt32(Console.ReadLine());
}

int AckerFunc(int n, int m)
{
	if (n == 0) 
        return m + 1;
	else if ((n != 0) && (m == 0)) 
        return AckerFunc(n - 1, 1);
	else 
        return AckerFunc(n - 1, AckerFunc(n, m - 1));
}

