/*
Задача 25: Напишите цикл, который принимает на вход два числа
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int MyPow(int A,int B)
{
    int s = 1;
    switch (B)
    {
    case 0:
        s = 0;
        return s;
    case 1:
        s = 1;
        return s;
    default:
    {
        for (int i = 1; i <= B; i++)
        {
            s *= A;
        }    
        return s;
    }
    }
}

int A = Convert.ToInt32(Console.ReadLine());

int B = Convert.ToInt32(Console.ReadLine());

//int pow = MyPow(A, B);

Console.Write($"{A}, {B} ->", A, B);
Console.WriteLine(MyPow(A, B));

/*
Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int num27 = Convert.ToInt32(Console.ReadLine());
int SumDigits(int num)
{
    int s = 0;
    while(num!=0)
    {
        s += num % 10;
        num /= 10;
    }
    return s;
}
Console.Write($"{num27} -> ", num27);
Console.WriteLine(SumDigits(num27));

/*
Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] a = new int[8];
for (int i = 0; i < 8; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());

}
Console.Write("{");
for (int i = 0; i < 8; i++)
{
    if(i != 7)
    {
        Console.Write($"{a[i]}, ",a[i]);
        
    }
    else
    {
        Console.Write($"{a[i]}",a[i]);
        Console.WriteLine("}");
    }
}
