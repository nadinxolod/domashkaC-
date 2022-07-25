/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

//Zadacha64();
void Zadacha64()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    AllNumber(m, n);
    


    void AllNumber(int m, int n)
    {
        if (m > n)
        {
            Console.WriteLine("другое!");
            return;
        }

        if (m % 3 == 0)
        {
            Console.WriteLine(m + "\t");
        }
        m++;
        AllNumber(m, n);
    }
}


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

//Zadacha66();
void Zadacha66()
{
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");
    int n = Convert.ToInt32(Console.ReadLine());
    
    AllNumber(m, n);
    
    void AllNumber(int m, int n, int sum=0)         
    {
        if (m > n)
        {
            Console.WriteLine(sum);
            return;
        }
        sum = sum+m;
        m++;
        AllNumber(m, n, sum);
    }



}


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29*/

Zadacha68();
void Zadacha68()
{



    Console.WriteLine("Введите число- М:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число- N:");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(AkkermanFunc(M,N));

        int AkkermanFunc(int m, int n)
        {
            if(m == 0)
            {

                return n+1;
            }
            else if(n==0)
            {

                return AkkermanFunc(m-1,1);
            }
            else 
            {

                return AkkermanFunc(m-1,AkkermanFunc(m,n-1));
            }
        }
}

