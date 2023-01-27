// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число в указанном диапазоне [10, 99]");
int number=int.Parse(Console.ReadLine());
if (Math.Abs(number)<10 || Math.Abs(number)>99)
{
    Console.WriteLine("Вы ввели число не из указанного диапазона");
    return;
}
int firstDigit = number/10;
int secondDigit = number%10;
int max=firstDigit>secondDigit?firstDigit:secondDigit;
Console.WriteLine("Наибольшая цифра введенного числа:"+max);
