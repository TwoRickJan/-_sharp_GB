
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

  

//[345, 897, 568, 234] -> 2

  
Console.WriteLine("\n***Задача 34***\n");
    int[] array = GeneateArray(3);
    PrintArray(array);
    int[] sumPositivAndNegativeNum = CulculateSumPositiveAndNegativeNumbers(array);
    Console.WriteLine($"Сумма положительных равна {sumPositivAndNegativeNum[0]}");
    Console.WriteLine($"Сумма отрицательных равна {sumPositivAndNegativeNum[1]}");
//
int[] GeneateArray(int length)
{
    //Генерирует массив случайных чисел от -9 до 9
    int[] array = new int[length];
    Random random = new Random();
    for(var i = 0; i < length; i++)
    {

        array[i] = random.Next(-9, 10);
    }
    return array;
}

  
int[] CulculateSumPositiveAndNegativeNumbers(int[] arrary)
{
    //Возващает сумму отрицательных элементов и сумму
    //положительных элементов числовго массива
    int sumPositive = 0;
    int sumNegative = 0;
    int[] out1 = new int[2];

    for(var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            sumPositive += array[i];
        }
        else{
            sumNegative += array[i];
        }
    }
    out1[0] = sumPositive;
    out1[1] = sumNegative;
    return out1;
}

  

void PrintArray(int[] array)
{
     Console.WriteLine($"[{string.Join(", ", array)}]");
}

  

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("\n***Задача 36***\n");
    int[] array2 = GeneateArray(5);

    PrintArray(array2);

    ArrayMultiply(array2, -1);

    PrintArray(array2);

int[] ArrayMultiply(int[] array, int factor)
{
    ///Возвращает массив, где каждый элемент array умножен на factor
    for(var i = 0; i < array.Length; i++)
    {
        array[i]*=factor;
    }
    return array;
}
  

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("\n***Задача 34***\n");

double[] array3 = GenRandArray(3);
PrintDoubleArray(array3);
double delta = ArrayMaxElem(array3)-ArrayMinElem(array3);
Console.WriteLine($"Разница между макс. и мин. эдементом массивы: {delta}");

double[] GenRandArray(int length){
	double[] array = new double[length];
	Random random = new Random();
	for(var i = 0; i < length; i++)
	{
		array[i] = random.NextDouble();
	}
	return array;
}

double ArrayMaxElem(double[] array){

	double max = array[0];
	for(var i = 1; i < array.Length; i++)
	{
		if (max<array[i]){
			max = array[i];
		}
	}
	return max;
}

double ArrayMinElem(double[] array){

	double min = array[0];
	for(var i = 1; i < array.Length; i++)
	{
		if (array[i]<min){
			min = array[i];
		}
	}
	return min;
}

void PrintDoubleArray(double[] array)
{
     Console.WriteLine($"[{string.Join(", ", array)}]");
}
