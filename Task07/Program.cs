// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int threedigitNumber=int.Parse(Console.ReadLine());
if (Math.Abs(threedigitNumber)<100 || Math.Abs(threedigitNumber)>999)
{
    Console.WriteLine("Вы ввели не трехзначное число :(");
    return;
}
int secondNumber = (threedigitNumber%100-threedigitNumber%10)/10;
Console.WriteLine("Вторая цифра Вашего числа: "+secondNumber);