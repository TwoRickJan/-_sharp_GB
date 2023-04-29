// Сгенерировать случайны вещественнй двумерный массив m*n
Console.WriteLine("\n***Задача 47***\n");

double[,] array = Generate2DArray(3, 4);
PrintDoubleArray(array);

void PrintDoubleArray(double[,] array)
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


double[,] Generate2DArray(int m, int n)
{
	double[,] array = new double[m, n];
	
	Random random = new Random();

	for (int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i, j] = Math.Round(random.NextDouble(),1);
		}
	}

	return array;
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/

Console.WriteLine("\n***Задача 50***\n");
int m = 5;
int n = 5;
int[,] array2 = Generate2DIntArray(m, n);
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());

if (IsPosApearIn2DArray(array2,i,j)){
    Console.WriteLine("Такой позиции нет");
}else{
    Console.WriteLine($"Значение элемента с позицией {i},{j} = {array2[i, j]}");
}

PrintIntArray(array2);

void PrintIntArray(int[,] array)
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
int[,] Generate2DIntArray(int m, int n)
{
	int[,] array = new int[m, n];
	
	Random random = new Random();

	for (int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			array[i, j] = random.Next(-10,10);
		}
	}
	return array;
}

bool IsPosApearIn2DArray(int[,] array, int i, int j){
	if(i<m && j<n){
		return false;
	}else{
		return true;
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите 
//среднее арифметическое элементов в каждом столбце.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("\n***Задача 52***\n");
// Задать int матриц. Найти ср. арифм. каждого столбика.
int m2 = 3;
int n2 = 1;
int[,] array3 = Generate2DIntArray(m2, n2);
double[] mean_line = GetMeanForEveryArrayColumn(array3);
PrintIntArray(array3);
PrintDoubleMassive(mean_line);

void PrintDoubleMassive(double[] massive)
{
     Console.WriteLine($"[{string.Join(", ", massive)}]");
}

double[] GetMeanForEveryArrayColumn(int[,] array){
	double[] mean_line = new double[array.GetLength(1)];
	double sum;
	for (int j = 0; j < array.GetLength(1); j++)
	{
		sum = 0;
		for(int i = 0; i < array.GetLength(0); i++)
		{
			sum+=Convert.ToDouble(array[i,j]) ;
		}
		mean_line[j] = sum/array.GetLength(0);
	}
    return mean_line;
}
