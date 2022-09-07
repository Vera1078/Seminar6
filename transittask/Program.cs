// Для перехода от одной задачи к другой, переходы по именам методов

Console.WriteLine("\n Введите номер задачи (34, 36, 37 или 38): \t");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine();

if (a == 34)
{
    RandomArray();
}

else if (a == 36)
{
    SumOfElements();
}

else if (a == 37)
{
    ResultArray();
}

else if (a == 38)
{
     RealNambersArray();
}

