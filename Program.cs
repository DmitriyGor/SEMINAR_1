/* Напишите программу, которaя на входе принимает число и выдает его квадрат (число умноженное на само себя)
Например:
4  -> 16 -> да
-3 -> 9
-7 -> 49
*/
// camelCase
/*
string?test = Console.ReadLine(); // NULL соответствует понятию «пустое поле», то есть «поле, не содержащее никакого значения». Введено для того, чтобы различать в полях БД пустые (визуально не отображаемые) значения
Console.Write ("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine()); // Переменная number - целое число, значение - 5

int result = number * number; // Если number = 5, то result = 5 * 5 (25)

// Math.Pow (число, степень) => (2, 3) => 2^3 = 2*2*2 = 8

double resultPartSecont = Math.Pow (number, 2); // number ^ 2
Console.WriteLine ("число " + number + " в квадрате, равно: " + result);
Console.WriteLine ("число " + number + " в квадрате, равно: " + resultPartSecont);
*/

/* Напишите программу, которaя на входе принимает два числа и проверят, является ли первое число квадратом второго
Например:
а = 25, в = 5 -> да
а = 2, в = 10 -> нет
а = -3, в = 9 -> нет
*/

/* Console.Write ("Введите первое число:  ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число:  ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
  // Да, истина 
Console.WriteLine ("число " + firstNumber + " является квадратом числа " + secondNumber);
}
else // нет
{
Console.WriteLine ("число " + firstNumber + " Не является квадратом числа " + secondNumber);
}
*/

/* Напишите программу, которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
Например:
4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
2 -> -2, -1, 0, 1, 2
*/
Console.Write ("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1); // -N  N = 5, negativeN = 5 * (-1) = -5
Console. WriteLine ("все целые числа в промежутке от " + negativeN + " до " + N);й
while (negativeN <= N)
{
    Console.Write (negativeN + ", ");
    negativeN ++; // negativeN = negativeN +1

}