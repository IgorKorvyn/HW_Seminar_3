//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 3));