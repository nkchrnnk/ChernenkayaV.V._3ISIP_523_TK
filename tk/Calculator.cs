using System;

namespace tk;

/// <summary>
/// Выполняет арифметическую операцию над двумя числами
/// в зависимости от переданного оператора.
/// Поддерживает операции сложения, вычитания, умножения и деления.
/// </summary>
/// <param name="a">Первое число</param>
/// <param name="b">Второе число</param>
/// <param name="operation">Строковое представление операции ("+", "-", "*", "/")</param>
/// <returns>Результат выполнения выбранной операции</returns>
/// <exception cref="DivideByZeroException">
/// Выбрасывается при попытке деления на ноль
/// </exception>
/// <exception cref="ArgumentException">
/// Выбрасывается, если передана неизвестная операция
/// </exception>
public static class Calculator
{
    public static double Calculate(double a, double b, string operation)
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 
                ? throw new DivideByZeroException()
                : a / b,
            _ => throw new ArgumentException("Неизвестная операция")
        };
    }
}