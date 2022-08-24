// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2, k2 задаются пользователем.


Console.Clear();

Console.Write("Ведите координаты прямых b1 k1 b2 k2 через пробел. Для дробных чисел используйте запятую: ");

double [] intersLine = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray(); 



if(intersLine.Length != 4) Console.WriteLine("Введены не все координаты. Повторите попытку.");

double b1 = intersLine[0];
double k1 = intersLine[1];
double b2 = intersLine[2];
double k2 = intersLine[3];

Console.WriteLine($"b1 = {Math.Round(b1, 2)}, k1 = {Math.Round(k1, 2)}, b2 = {Math.Round(b2, 2)}, k2 = {Math.Round(k2, 2)}; ");


double OrdinX = 0;
double OrdinY = 0;

if (b1 == b2 || k1 == k2)
{
     Console.WriteLine("Прямые не пересекаются.");
}
else
{
    OrdinX = (b1 - b2) / (k2 - k1);
    OrdinY = k2*OrdinX + b2;
    Console.WriteLine($"Точка пересечения прямых: ({Math.Round(OrdinX, 2)}, {Math.Round(OrdinY, 2)});");
}