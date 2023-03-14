// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке 
//  от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
class RecExercise1
{
    static int printNatural(int rows,int cols)
    {
	if (rows < 1)
	{
	    return cols;
	}

	Console.Write(" {0} ",rows);
		rows--;
	return printNatural(rows,cols);
    }
    
    static void Main()
    {
	Console.Write(" Введите число N : ");
	int ctr= Convert.ToInt32(Console.ReadLine());
	printNatural(ctr,1);
    }
}


*/



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


/*


Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());


/// <summary>
/// Этот метод находит сумму натуральных элементов от М до N
/// </summary>
/// <param name="numberM">от</param>
/// <param name="numberN">до</param>
/// <param name="sum">сумма</param>
void GetNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GetNumberSum(numberM, numberN, sum);
}

GetNumberSum(numberM, numberN, 0);


*/




// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/*

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

/// <summary>
/// Вычисление функции Аккермана через рекурсии  
/// </summary>
/// <param name="m">первое положительное число </param>
/// <param name="n">второе положительное число </param>
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/