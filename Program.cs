// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*bool Palindrome(int num)
{
    int current = num;
    int reverse = 0;

    while (current > 0)
    {
        reverse = reverse * 10 + current % 10;
        current = current / 10;
    }

    if (num == reverse)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool finding = Palindrome(num);
Console.Write(finding);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double FindDistance(double xA, double xB, double yA, double yB, double zA, double zB)

{
    double distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    return distance;
}

Console.Write("Input first coordinate of first point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second coordinate of first point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third coordinate of first point: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first coordinate of second point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second coordinate of second point: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third coordinate of second point: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dis = Math.Round(FindDistance(xA, xB, yA, yB, zA, zB), 1);

Console.Write("Distanse from point A to B is " + dis);
*/

// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void CubeNum(int n)
{
    int current = 1;

    while (current <= n)
    {
        Console.Write(Math.Pow(current, 3) + " ");
        current++;
    }
}

Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

CubeNum(n);
*/

