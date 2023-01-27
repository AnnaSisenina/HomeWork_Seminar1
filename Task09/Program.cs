// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int threedigitNumber=int.Parse(Console.ReadLine());
if (Math.Abs(threedigitNumber)<100 || Math.Abs(threedigitNumber)>999)
{
    Console.WriteLine("Вы ввели не трехзначное число :(");
    return;
}
int firstDigit = threedigitNumber/100;
int thirdDigit = threedigitNumber%10;
int newNumber = firstDigit*10+thirdDigit;
Console.WriteLine("Число без второй цифры: "+newNumber);
