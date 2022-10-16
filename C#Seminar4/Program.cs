//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double stepen(double a,int b)
{
    return Math.Pow(a,b);
}

Console.WriteLine("Введите основание степени");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите показатель степени");
int b = Convert.ToInt32(Console.ReadLine());
double st = stepen(a,b);
Console.WriteLine($"Степень с основанием {a} и показателем {b} будет равна {Math.Round(st,2)} ");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int summ(int num)
{
    if(num < 0) num*=-1;
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num /= 10; 
    }
    return sum;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int s = summ(number);
Console.WriteLine($"Сумма цифр числа {number} равна {s} ");

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// запрос элементов от пользователя

int[] CreateArray(int size)
{   int[] array = new int [size]; 
    for( int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array [i] = Convert.ToInt32(Console.ReadLine());  
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);


// домашнее задание

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-1000,1000);
    }
    return array;
}
void ShowArray1(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("Vvedite kolichestvo array");
int num1=Convert.ToInt32(Console.ReadLine());
int[] myArray1 = CreateRandomArray(num1);
ShowArray1(myArray1);
