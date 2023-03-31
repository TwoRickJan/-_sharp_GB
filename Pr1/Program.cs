/*
Задачf 2: Напишите программу, которая на вход принимает
 два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int max = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int v;
if(max<min)
{
    v = max;
    max = min;
    min = v;
}
Console.WriteLine($"max -> {max}",max);

/*
Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int maxx = a;

if(maxx<b)
{
    maxx = b;
};
if(maxx<c)
{
    maxx = c;
};

Console.WriteLine($"{a},{b},{c} -> {maxx}",a,b,c,maxx);


/*
Задача 6: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два 
без остатка).

4 -> да
-3 -> нет
7 -> нет
*/


int num6 = Convert.ToInt32(Console.ReadLine());
if(num6 % 2==0)
{
Console.WriteLine($"{num6} -> да",num6);
}
else
{
Console.WriteLine($"{num6} -> нет",num6);
}

/*
Задача 8: Напишите программу, которая на 
вход принимает число (N), а на выходе показывает
 все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int aa = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= aa; i++)
{
    if (i%2==0)
    {
        Console.Write(i);
        Console.Write(", ");
    };
};

