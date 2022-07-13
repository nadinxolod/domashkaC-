//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2  |  1, -7, 567, 89, 223-> 3

//Zadacha41();
void Zadacha41()
{
Console.WriteLine("Введите колличество чисел для проверки");
int kol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа");
int num;
int count=0;

while (kol>0)
{
    num = Convert.ToInt32(Console.ReadLine());
if (num>0)
{
    count=count+1;
} 
kol--;
}

Console.WriteLine($"колличество чисел больше нуля {count}");
}

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
b1 = 2, k1 = 5, b2 = 4,   |    k2 = 9 -> (-0,5; -0,5)*/

Zadacha42();
void Zadacha42()
{
Console.WriteLine("введите значения точек (b1,k1,b2,k2)");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
TochkaPeresechen(b1,k1,b2,k2);
}

void TochkaPeresechen(double b1, double k1, double b2, double k2)
{
double y;
double x;

x = (b2 - b1)/(k1 - k2);
y = (k1*x) + b1;

Console.WriteLine(y);
Console.WriteLine(x);
}
