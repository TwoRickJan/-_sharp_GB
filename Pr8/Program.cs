
Console.WriteLine("\n***Задача 54***\n");
//Инициализировать матрицу. Упорядочить по убыванию элементы каждой строки

int m = 3;
int n = 6;
int[,] a = Generate2DIntArray(m,n);


//PrintIntMassive(massive);
//int[,] sorted_a = SortEveryColumnOfArray();
Console.WriteLine("Исходный массив:");
Print2DIntArray(a);
Console.WriteLine("Отсортированный массив:");
Print2DIntArray(SortArray54(a));

int[,] SortArray54(int[,] a){
	int[] temp_vec = new int[a.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++){
		
        for (int j = 0; j < a.GetLength(1); j++){
         temp_vec[j] = a[i,j];     
        }
        
        BubleSortVec(temp_vec);
        
        for (int j = 0; j < a.GetLength(1); j++){
          a[i,j] = temp_vec[j];     
        }
	}
    return a;
}


/*int[] GeneateIntMassive(int length)
{
    //Генерирует массив случайных чисел от -9 до 9
    int[] array = new int[length];
    Random random = new Random();
    for(var i = 0; i < length; i++)
    {

        array[i] = random.Next(-9, 10);
    }
    return array;
}*/

/*void PrintIntMassive(int[] massive)
{
     Console.WriteLine($"[{string.Join(", ", massive)}]");
}
*/
int[,] Generate2DIntArray(int m, int n)
{
	int[,] array = new int[m, n];
	
	Random random = new Random();

	for (int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i, j] = random.Next(0,10);
		}
	}
	return array;
}
int[] BubleSortVec(int[] arr){
        int temp = 0;
        for (int write = 0; write < arr.Length; write++) {
            for (int sort = 0; sort < arr.Length - 1; sort++) {
                if (arr[sort] < arr[sort + 1]) {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
    return arr;
}
void Print2DIntArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j]);
			Console.Write(" ");
		}
		Console.WriteLine();
	}
}

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("\n***Задача 54***\n");

//Инициализировать прямоугольную матрицу. Возвратить строку с минимальной суммой по элементам
int m54 = 3;

int[,] a54 = Generate2DIntCubeArray(m54);
int MinSumOf_a_index = ArrayMinSumVecIndex(a54);

Print2DIntArray(a54);
Console.WriteLine($"Минимальная сумма находится в строке i = {MinSumOf_a_index}");

int[,] Generate2DIntCubeArray(int m)
{
	int[,] array = new int[m, m];
	
	Random random = new Random();

	for (int i = 0; i < m; i++)
	{
		for(int j = 0; j < m; j++)
		{
			array[i, j] = random.Next(0,10);
		}
	}
	return array;
}

int ArrayMinSumVecIndex(int[,] a){
	int min_sum = 0;
    int vec_sum = 0;
    int FirstSum = 0;
    int temp_i = 0;
    for (int i = 0; i < a.GetLength(0); i++){
		vec_sum = 0;
        for (int j = 0; j < a.GetLength(1); j++){
         vec_sum += a[i,j];     
        }
        
        if (FirstSum == 0){
            min_sum = vec_sum;
            FirstSum = 1;
            temp_i = i;
        }else{
            if (vec_sum < min_sum)
            {
                min_sum = vec_sum;
                temp_i = i;
            }
        }
	}
    return temp_i;
}

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("\n***Задача 58***\n");
//Инициализировать две матрицы. Посчитать произведение двух матриц
int m58 = 2;
int n58 = 2;
int[,] A58_1 = Generate2DIntArray(m58,n58);
int[,] A58_2 = Generate2DIntArray(m58,n58);
Console.WriteLine("Матрица A:");
Print2DIntArray(A58_1);
Console.WriteLine("Матрица B:");
Print2DIntArray(A58_2);
Console.WriteLine("Матрица A*B=C:");
Print2DIntArray(Multiplication(A58_1,A58_2));


int[,] Multiplication(int[,] a, int[,] b){
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) == b.GetLength(0)){
    //int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    
    for (int i = 0; i < a.GetLength(0); i++){
        for (int j = 0; j < b.GetLength(1); j++){
            for (int k = 0; k < b.GetLength(0); k++){
                        
                        r[i,j] += a[i,k] * b[k,j];
                    
                    }
                }
            }
            return r;
        }else{
            Console.WriteLine("Ошибка размерности матриц");
            return r;
        }
    
    }

/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("\n***Задача 60***\n");
int[,,] a60 = Generate3DIntArray(2, 2, 2);
Print3DIntArray(a60);
int[,,] Generate3DIntArray(int m, int n, int s)
{
	int[,,] array = new int[m, n, s];
	
	Random random = new Random();

	for (int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
            for(int k = 0; k < s; k++)
            {
                array[i, j, k] = random.Next(-9,10);
            }
		}
	}
	return array;
}

void Print3DIntArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
	{
		for(int i = 0; i < array.GetLength(0); i++)
		{
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})");
			    Console.Write(" ");
                
            }
            Console.WriteLine();
		}
	}
}
/*
void Print2DIntArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j]);
			Console.Write(" ");
		}
		Console.WriteLine();
	}
}*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("\n***Задача 62***\n");

    int n60 = 4;
    int[,] sqareMatrix = new int[n60, n60];

    int temp60 = 1;
    int i60 = 0;
    int j60 = 0;

    while (temp60 <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
    sqareMatrix[i60, j60] = temp60;
    temp60++;
    if (i60 <= j60 + 1 && i60 + j60 < sqareMatrix.GetLength(1) - 1)
        j60++;
    else if (i60 < j60 && i60 + j60 >= sqareMatrix.GetLength(0) - 1)
        i60++;
    else if (i60 >= j60 && i60 + j60 > sqareMatrix.GetLength(1) - 1)
        j60--;
    else
        i60--;
    }

    WriteArray(sqareMatrix);

    void WriteArray (int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");

        else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    }