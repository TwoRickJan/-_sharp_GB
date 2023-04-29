
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
Console.WriteLine("\n***Задача 54***\n");


/*int[] PrintList(int[] list){

}*/

/*// Сгенерировать случайны вещественнй двумерный массив m*n
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
/*
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
}*/
/*
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
/*
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
*/