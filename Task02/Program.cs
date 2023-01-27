// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели от 1 до 7 включительно");
int dayWeekNumber = int.Parse(Console.ReadLine());
if (dayWeekNumber==1)
Console.WriteLine ("Это понедельник");
else
{
    if (dayWeekNumber==2)
Console.WriteLine ("Это вторник");
else 
{
if (dayWeekNumber==3)
Console.WriteLine ("Это среда");
else
{
    if (dayWeekNumber==4)
Console.WriteLine ("Это четверг");
else
{
if (dayWeekNumber==5)
Console.WriteLine ("Это пятница");
else 
{
if (dayWeekNumber==6)
Console.WriteLine ("Это суббота");
else{

if (dayWeekNumber==7)
Console.WriteLine ("Это воскресенье");
else
Console.WriteLine ("вы ввели число, которое не входит в указанный диапазон :(");
}
}
}
}
}
}