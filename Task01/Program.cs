// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = int.Parse(Console.ReadLine());
if (secondNumber*secondNumber==firstNumber)
Console.WriteLine("Первое число является квадратом второго числа");
else
Console.WriteLine("Первое число не является квадратом второго числа");