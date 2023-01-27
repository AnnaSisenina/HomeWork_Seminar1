// Показать четные числа от 1 до N
Console.WriteLine("Введите натуральное число ");
int N = int.Parse(Console.ReadLine());
if (N<1)
{
    Console.WriteLine("Вы ввели ненатуральное число :(");
    return;
}
Console.WriteLine("Четные числа от 1 до "+N+":");
for (int count =1;count<=N;count++)
{
    if (count%2==0)
    Console.WriteLine(count);
}
