// Выяснить, кратно ли число заданному, если нет, вывести остаток
int givenNumber = 3;
Console.WriteLine("Введите число ");
int number = int.Parse (Console.ReadLine());
if (number%givenNumber==0)
Console.WriteLine("Число "+number+" кратно "+givenNumber);
else
Console.WriteLine("Остаток от деления "+number+" на "+givenNumber+" равен "+number%givenNumber);