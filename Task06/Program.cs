// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int threedigitNumber=int.Parse(Console.ReadLine());
if (Math.Abs(threedigitNumber)<100 || Math.Abs(threedigitNumber)>999)
{
    Console.WriteLine("Вы ввели не трехзначное число :(");
    return;
}
int remainder = threedigitNumber%10;
Console.WriteLine("Последняя цифра Вашего числа: "+remainder);