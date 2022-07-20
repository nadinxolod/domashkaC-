/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/

//Zadacha54 ();
void Zadacha54 ()
{
    Console.WriteLine("введите кол-во строчек");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во столбцов");
    int colons = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random(); 
    int [,] array = new int [rows,colons];
    
    CreateMassive(array, rows, colons);
    int [,] CreateMassive(int [,]array, int rows, int colons)
    {
        Random rand = new Random(); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colons; j++)
            {
                array[i,j]=rand.Next(0,10); 
            }
        }
        return array;
    }
    
    PrintArray(array, rows, colons);
    void PrintArray ( int [,]array, int rows, int colons)
    {
    for (int i = 0; i < rows; i++)                          
    {
        for (int j = 0; j < colons; j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    }

    PoryadorArray(array, rows, colons);
    int [,] PoryadorArray( int [,]array, int rows, int colons)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colons-1; j++)
            {
                for (int p = 0; p < colons-1; p++)
                
                {
                    if (array[i,p]<array[i,p+1])
                    {
                    (array[i,p],array[i,p+1])=(array[i,p+1], array[i,p]);
                    }
                }
            }
        }  
        return array;
    }
    Console.WriteLine();
 PrintArray(array, rows, colons);
}


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//Zadacha56 ();
void Zadacha56 ()
{
    Console.WriteLine("введите кол-во строчек");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите кол-во столбцов");
    int colons = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random(); 
    int [,] array = new int [rows,colons];

    CreateMassive(array, rows, colons);
    int [,] CreateMassive(int [,]array, int rows, int colons)
    {
        Random rand = new Random(); 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colons; j++)
            {
                array[i,j]=rand.Next(0,10); 
            }
        }
        return array;
    }
    
    PrintArray(array, rows, colons);
    void PrintArray ( int [,]array, int rows, int colons)
    {
    for (int i = 0; i < rows; i++)                          
    {
        for (int j = 0; j < colons; j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    }

    SummaArray(array,rows,colons);
    int [] SummaArray( int [,]array, int rows, int colons)
    {
        int [] Massive = new int[rows];
        int sum = 0;
        int k = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = 0;
            for (int j = 0; j < colons; j++)
            {
                sum = sum + array [i,j];
            }
            
            Massive [k] = sum; 
            k++;

        }
        return Massive;
    }
        
        MinSum(SummaArray(array,rows,colons));
        void MinSum(int [] Massive)
        {   int indexMin = 0;
            int min = Massive[0];
            for (int i = 0; i < Massive.Length; i++)
            {
                if (Massive[i]<min)
                {
                 min = Massive[i];
                 indexMin = i;
                }
            }
            Console.WriteLine($"минимальная сумма строки {min}, строка {indexMin+1}");
        }
        MinSum(SummaArray(array,rows,colons));


}

/*Задача 58. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1  2  3  4

12 13 14 5

11 16 15 6

10  9  8  7*/
Zadacha58 ();
void Zadacha58 ()
{
   
    int [,] array = new int [4,4];
    
    CreateMassive(array);
    int [,] CreateMassive(int [,]array)
    {
        int index  = 1;
        int rows = array.GetLength(0);
        int colons = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colons; j++)
            {
                if (i == 0)
                {
                array[i,j]=index; 
                index ++;
                }
            }
        }

         for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j < colons; j++)
            {
                if (j <= colons-1 && i == rows-1)
                {
                array[j,i]=index; 
                index ++;
                }
            }
        }
            for (int i = rows-1; i > 0; i--)
        {
            for (int j = colons-1; j > 0; j--)
            {
                if (i == 3 && j != colons-1)
                {
                array[i,j]=index; 
                index ++;
                }
            }
        }

        for (int i = rows-1; i >= 0; i--)
        {
            for (int j = colons-1; j >= 0; j--)
            {
                if (i ==0 && j>0)
                {
                array[j,i]=index; 
                index ++;
                }
            }
        }

  for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colons; j++)
            {
                if (i == 1 && j!=0 && j!=colons-1)
                {
                array[i,j]=index; 
                index ++;
                }
            }
        }
 
 for (int i = rows-1; i > 0; i--)
        {
            for (int j = colons-1; j > 0; j--)
            {
                if (i == 2 && j!=0 && j!=colons-1)
                {
                array[i,j]=index; 
                index ++;
                }
            }
        }
        return array;

    }
    
    PrintArray(array,4,4);
    void PrintArray ( int [,]array, int rows, int colons)
    {
    for (int i = 0; i < rows; i++)                          
    {
        for (int j = 0; j < colons; j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
    }
}