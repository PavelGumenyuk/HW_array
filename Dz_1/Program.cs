// Задача 1: Задайте одномерный массив из 10 целых чисел 
// от 1 до 100. Найдите количество элементов массива, значения 
// которых лежат в отрезке [20,90].

// Console.WriteLine("Введите чило");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// int[] array = new int[num];

// for(int i = 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0, 101);
//     System.Console.WriteLine(array[i]+ " ");

//     if (array[i]>=20 && array[i]<=90)
//     {
//         count = count ++;
//     } 
// }

// System.Console.WriteLine();
// System.Console.WriteLine(count);


// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// Console.WriteLine("Введите чило");
// int num = Convert.ToInt32(Console.ReadLine());

// int[]array = new int[10];
// int count = 0;

// for (int i =0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 21);
//     Console.WriteLine(array[i] + " ");
//     if (array[i] %2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine(count);


// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


// Console.WriteLine ("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[num];
// double Min = double.MaxValue;
// double Max = double.MinValue;
// double result = 0;

// for(int i = 0; i<array.Length; i++)
// {
//     array[i]= new Random().NextDouble()*100;
//     System.Console.Write(Math.Round((array[i]), 2)+ " ");
// }
// Console.WriteLine();
// for (int i = 0; i<array.Length; i++)
// {
//     if(array[i] < Min)
//     {
//         Min = array[i];
//     }

//     if(array[i] > Max)
//     {
//         Max = array[i];
//     }
// }
// result = Max = Min;
// System.Console.WriteLine(Math.Round(result, 2));