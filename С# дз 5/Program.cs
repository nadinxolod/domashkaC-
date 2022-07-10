
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
 /*Console.WriteLine("введите число");
 int Length = Convert.ToInt32(Console.ReadLine());
 int [] array = new int [Length];
    Random rand = new Random(); 


int [] CreateMasive ( int []arr)
{
for (int i = 0; i < arr.Length; i++)                          //Создание массива
{
    arr[i]=rand.Next(100, 999); 
}
return arr;
}

void PrintMassiv(int [] arr2)
{
    for (int i = 0; i < arr2.Length; i++)                    //Вывод массива
    {
        Console.Write(arr2[i] + " ");
    }
}

void EvenMassive(int []arr3)
{
    int b=0;
    for (int i = 0; i < arr3.Length; i++)
    {
          if (arr3[i] % 2==0)                                 // Проверка на четность
          {
            b=b+1;
          }
    }
    Console.WriteLine(b);
}

CreateMasive (array);
PrintMassiv(array);
Console.WriteLine();
EvenMassive(array);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0

/*Console.WriteLine("введите число");
 int Length = Convert.ToInt32(Console.ReadLine());
 int [] array = new int [Length];
    Random rand = new Random(); 


int [] CreateMasive ( int []arr)
{
for (int i = 0; i < arr.Length; i++)                          //Создание массива
{
    arr[i]=rand.Next(100, 999); 
}
return arr;
}

void PrintMassiv(int [] arr2)
{
    for (int i = 0; i < arr2.Length; i++)                    //Вывод массива
    {
        Console.Write(arr2[i] + " ");
    }
}

void EvenMassive(int []arr3)
{
    int b=0;
    for (int i = 0; i < arr3.Length; i++)
    {
          if (i%2==1)                                // Проверка на четность
          {
            b=b+arr3[i];
          }
    }
    Console.WriteLine(b);
}

CreateMasive (array);
PrintMassiv(array);
Console.WriteLine();
EvenMassive(array);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.   [3 7 22 2 78] -> 76

Console.WriteLine("введите максимальную длину массива");
 int Length = Convert.ToInt32(Console.ReadLine());
 double [] array = new double [Length];
    Random rand = new Random(); 


double [] CreateMasive ( double []arr)
{
for (int i = 0; i < arr.Length; i++)                          //Создание массива
{
    arr[i]=rand.NextDouble()*100.0; 
    arr[i]=Math.Round(arr[i], 2);
}
return arr;
}

void PrintMassiv(double [] arr2)
{
    for (int i = 0; i < arr2.Length; i++)                    //Вывод массива
    {
        Console.Write(arr2[i] + " ");
    }
}

void FindMaxMinAndSum(double[] arr3)
{   double sum;
    double max=arr3[0];
    double min=arr3[0]; 
    for (int i = 0; i < arr3.Length; i++)
    {
        if (max<arr3[i])
        {
            max=arr3[i];
        }
        else if (min>arr3[i])
        {
            min=arr3[i];
        }
    }
 sum=max-min;
Console.WriteLine(sum);
}

CreateMasive (array);
PrintMassiv(array);
Console.WriteLine();
FindMaxMinAndSum(array);
