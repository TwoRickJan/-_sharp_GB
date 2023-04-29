// Пользватель вводит с клавиатуры М чисел. Посчитать, сколько
// чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3
/*int length = Prompt("Введите кол-во элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во чисел больше 0: {CountPositiveNumbers(array)}");

int Prompt(string message)
{
	//Читает число с консоли
	System.Console.Write(message);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int[] InputArray(int length)
{
	// Ввести массив, ну тот же генратор только ввод
	int[] array = new int[length];
	for (int i = 0; i < array.Length;i++)
	{
		array[i] = Prompt($"Введите ({i + 1})-й элемет");	
	}
	return array;
}

void PrintArray(int[] array)
{
	// Выводит массив
	for(int i = 0;i < array.Length;i++)
	{
		Console.WriteLine($"a[{i}] = {array[i]}");
	}
}

int CountPositiveNumbers(int[] array)
{
	
	int count = 0;
	for(int i = 0;i < array.Length;i++)
	{
		if (array[i] > 0)
		{
			count++;
		}
	}
	return count;
}*/


//Задача 43

// Программа находит точку пересечения двух прямых с заданным уравненим. 
// Т.е. принимает коэф.-ты b1 k1 b2 и k2 и возваращет точку с двумя еоординатами

const int COEFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if(ValidateLines(lineData1, lineData2))
{
	double[] coord = FindCoords(lineData1,lineData2);
	Console.Write($"Точка пересечения уравений  y={lineData1[COEFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFICIENT]}*x+{lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");			  
}
int Prompt(string message)
{
	//Читает число с консоли
	System.Console.Write(message);
	string value = Console.ReadLine();
	Double result = Convert.ToDouble(value);
	return result;
}

double[] InputLineData(int numberOfLine)
{
	double[] lineData = new double[2];
	lineData[COEFICIENT] = Prompt($"Введите коэф. для {numberOfLine} прямой >");
	lineData[COEFICIENT] = Prompt($"Введите конст. для {numberOfLine} прямой >");
	return lineData;
}
double[] FindCoords(double[] lineData1,double[] lineData2)
{
	double[] coord = new double[2];
	coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFICIENT] - lineData1[COEFICIENT]);
	coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT]; //Бред?
	return coord;
}
				  
bool ValidateLines(double[] lineData1,double[] lineData2)
{
	if (lineData1[COEFICIENT] == lineData2[COEFICIENT])
	{
		if (lineData1[CONSTANT] == lineData2[CONSTANT])
		{
			Console.WriteLine("Прямые совпадают");
			return false;
		}else{
			Console.WriteLine("Прямые прямые параллельны");
			return false;
		}
	}
	return true;
}
