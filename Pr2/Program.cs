﻿
/*
Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num%100/10);


/*
Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int num13 = Convert.ToInt32(Console.ReadLine());
if(num13%100!=num13)
{
    int s=num13;
    while(s%1000!=s)
    {
        s=s/10;
    };
    Console.WriteLine(s%10);
}
else
{
    Console.WriteLine("третей цифры нет");
};

/*
Задача 15: Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, является ли
этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int num15 = Convert.ToInt32(Console.ReadLine());

if((num15==6)|(num15==7))
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");
}
