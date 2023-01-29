// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число ");
int number=int.Parse(Console.ReadLine());
int thirdDigit; //третья цифра введенного числа от начала
int variableForRank=number/10;
int count=0;
int firstSecondDigit;
int firstSecondRank;
while (variableForRank!=0) // считаем разрядность числа
{
    variableForRank=variableForRank/10;
    count++;
}
if (count<2)
Console.WriteLine("У этого числа нет третьей цифры");
else
{
firstSecondDigit=number/Convert.ToInt32(Math.Pow(10,(count-1))); //находим первые две цифры числа
firstSecondRank=firstSecondDigit*Convert.ToInt32(Math.Pow(10,(count-1))); //находим разряд первыйх двух цифр
thirdDigit=Math.Abs((number-firstSecondRank)/Convert.ToInt32(Math.Pow(10,(count-2)))); //находим третью цифру. Для этого из данного числа вычитаем полученное выше число и делим на разряд третьей цифры
Console.WriteLine("Третья цифра числа - "+thirdDigit);
}