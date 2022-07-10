
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

Console.WriteLine("введите число");
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
