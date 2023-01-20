// ДЗ
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 
Console.WriteLine("Введите размер массива n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,]array=new double[m,n]; 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array [i,j] = Convert.ToDouble(new Random().Next(-10,10))/10; // Math.Roundom(new Random).NextDouble()*100,2)
        Console.Write($"{array[i,j]} "); 
    } 
   Console.WriteLine(); 
} 


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,]array=new int[5,5]; 
for (int i = 0; i < array.GetLength(0); i++) // строка
{ 
    for (int j = 0; j < array.GetLength(1); j++) // столбец
    { 
        array [i,j] = new Random().Next(0,100); 
        Console.Write($"{array[i,j]} "); 
    } 
   Console.WriteLine(); 
} 
Console.WriteLine("Введите позиции элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a>5 && b>5) System.Console.WriteLine("Такого числа нет");
else 
{
     Console.WriteLine("Значение элемента массива = {0}", array[a,b]);
}
Console.WriteLine();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 
Console.WriteLine("Введите размер массива n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array=new int[m,n]; 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array [i,j] = new Random().Next(1,10); 
        Console.Write($"{array[i,j]+ " "}"); 
    } 
   System.Console.WriteLine();
}
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double SrArifm = 0;
    double rezult =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SrArifm = SrArifm + array[i,j];
    }
    rezult= SrArifm / array.GetLength(1);
    Console.Write(Math.Round(rezult,1)+ " ; "); 
}
System.Console.WriteLine();

