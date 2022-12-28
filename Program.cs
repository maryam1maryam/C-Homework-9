//Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

void ShowNumbers(int number)
{
    if (number == 0) { return; }
    System.Console.Write($"{number} ");
    ShowNumbers(number - 1);
}
int N = Prompt("Введите число: ");
ShowNumbers(N);*/




//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


/*int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int Sum(int m, int n)
{
    if (n < m) { return 0; }
    return n + Sum(m, n-1);
}

int m = Prompt("Введи число M: ");
int n = Prompt("Введи число N: ");
System.Console.WriteLine($"{Sum(m, n)}");*/


//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int FunctionAckerman(int m, int n)
{
    int result = n + 1;
    if (m == 0)
    {
        return result;
    }
    else if ((m > 0) && (n == 0))
    {
        return FunctionAckerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
    else
        return result;
}

int m = Prompt("Введите значение m -> ");
int n = Prompt("Введите значение n -> ");
System.Console.WriteLine($"A({m},{n}) = {FunctionAckerman(m, n)}");*/
