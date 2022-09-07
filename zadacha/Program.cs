//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Clear();
Write("Введите стороны треугольника через пробел: ");

string[] st=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

if(IsTriangle(int.Parse(st[0]),int.Parse(st[1]),int.Parse(st[2])))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}



bool IsTriangle(int a,int b,int c)
{
    return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
}



//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

Clear();
int number=int.Parse(ReadLine());

string res1=Convert.ToString(number,2);
string res2=DecToNum(number,2);

WriteLine($"{number}->{res1}");
WriteLine($"{number}->{res2}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums="0123456789ABCDEF";
    while(decNumber>0)
    {
        int ost=decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}
//Универсальный математический для перевода из 10 в двоичную
bool[] DecToNum2 (int num)
{

int result = 0;
bool[] arr = new bool[32];
int i;
for (i = 0; num > 0; i++)
{
    result = num%2;
    num = num/2;
    arr[arr.Length -1 -i] = Convert.ToBoolean(result);
}
return arr;
}
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Clear();

int[] array = GetArray(10, 0, 10);
WriteLine(String.Join(" ", array));

int[] copyArray=CopyArray(array);
WriteLine(String.Join(" ", copyArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
double FibonacciBad(int n)
{
	if(n == 1 || n == 2) return 1;
	else return FibonacciBad(n-1) + FibonacciBad(n-2);
}

double FibonacciR(double[] f, int n)
{
	if(n == 1 || n == 2) 
    {
        return f[n-1] = 1;
    }
	else
    {
        if(f[n-2]!=0)
        {
            if(f[n-1]!=0)
                return f[n-1] = f[n-2] + f[n-3];
            else
                return  f[n-1] = FibonacciR(f, n-1) + f[n-3];
        }
        else
            return f[n-1] = FibonacciR(f, n-1) + FibonacciR(f, n-2);
    }
}
double FibonacciGood(int n)
{
    
    double[] f = new double[n];
    return FibonacciR(f, n);
}


int countTests = 45;


DateTime saveTime;

Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
	Console.WriteLine($"f({i}) = {fibonacci2}");
	int temporary = fibonacci2;
	fibonacci2 += fibonacci1;
	fibonacci1 = temporary; 
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
	Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

	Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");
System.Console.WriteLine();
Console.ReadLine();

//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
Console.Clear();

int[] array = GetArray(10, 0, 10);


System.Console.WriteLine();

Console.WriteLine("Array " + String.Join(" ", array));
ReversArray1(array);
Console.WriteLine("ReversArray1 : " + String.Join(" ", array));

System.Console.WriteLine();

Console.WriteLine("Array " + String.Join(" ", array));
int[] reversArray = ReversArray2(array);
Console.WriteLine("ReversArray2 : " + String.Join(" ", reversArray));

System.Console.WriteLine();

Console.WriteLine("Array " + String.Join(" ", array));
ReversArray3(array);
Console.WriteLine("ReversArray3 : " + String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int numTemp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = numTemp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}

void ReversArray3(int[] inArray)
{
    Array.Reverse(inArray);
}

