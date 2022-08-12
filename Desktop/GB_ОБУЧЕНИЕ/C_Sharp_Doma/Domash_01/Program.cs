// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();
//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
int a, b;
Console.WriteLine("Введи первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число - ");
b = Convert.ToInt32(Console.ReadLine());
 
    bool Chto0 = a > b;
    bool Chto1 = a == b;
    bool Chto2 = a < b;
 
    if (Chto0)
    {
        Console.WriteLine($"Число {a} больше чем {b} ");
    }
        else if (Chto1)
        {
        Console.WriteLine($"Числа {a} и {b} равны");
        }
        else
        {
        Console.WriteLine($"Число {b} больше чем {a}");
        }