/*
Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int num = Convert.ToInt32(Console.ReadLine());
bool IsFiveDigitNum(int num)
{
    int count = 0;
    if(num == 0)
    {
        count = 1;
    }
    else
    {
        while(num > 0)
        {
            count += 1;
            num /= 10;
        }
    }
  return count == 5;
}
bool IsPalindrome(int num)
{
    int a = num%1000;
    int b = num/1000;
    int c = a%10*10+a%100/10;
    return c == b;

}

if (IsFiveDigitNum(num))
{
    if (IsPalindrome(num))
    {
        Console.WriteLine("да");
        return;
    }
}
else
{
    Console.WriteLine("число не из 5 цифр");
    return;
}
Console.WriteLine("нет");

/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double[] A = {0,0,0};
double[] B = {0,0,0};

Console.WriteLine("Введите коор-ты т. А(x,y,z):");
for (int i = 0; i < 3; i++)
{
    A[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите коор-ты т. B(x,y,z):");
for (int i = 0; i < 3; i++)
{
    B[i] = Convert.ToDouble(Console.ReadLine());
}
double diffAB = 0; 
for (int i = 0; i < 3; i++)
{
    diffAB += Math.Pow((B[i]-A[i]),2);
}

double dist = Math.Sqrt(diffAB);

Console.WriteLine($"{dist}", dist);



/*
Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i,3));
    Console.Write(",");
}   