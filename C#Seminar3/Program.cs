//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool polind(int fivenumber)
{
    if(fivenumber > 9999 && fivenumber < 100000)
    {
        if(fivenumber % 10 == fivenumber / 10000 && fivenumber / 1000 %10 == fivenumber % 100 / 10)
        {
            return true;

        }
        else
        {
            return false;

        }
    } 
    else
    {
        return false;
    }
    
}
Console.WriteLine("Введите 5значное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 9999 && number < 100000)
{
    Console.WriteLine(polind(number));

}
else
{
    Console.WriteLine("Введено неправильное число");
}


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double long3d(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double l = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return Math.Round(l,2);
}
Console.WriteLine("Введите X");
double x1 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y");
double y1 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z");
double z1 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X1");
double x2 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y1");
double y2 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z1");
double z2 =  Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние Между двумя точками А ({x1}, {y1}, {z1}) и В({x2}, {y2}, {z2}) в трехмерном пространстве составляет = {long3d(x1, y1, z1, x2, y2, z2)}");



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void shownumber(int num)
{
    int count = 1;
    while(num >= count)
    {
        double num1 = Math.Pow(count,3);
        Console.Write(num1 + " ");
        count++;
    }
}
Console.WriteLine("Введите N");
int N =  Convert.ToInt32(Console.ReadLine());
shownumber(N);
