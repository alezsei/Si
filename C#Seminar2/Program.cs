// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int twonumber(int a)
{   
    int result;
    result = a / 10 ;
    result = result % 10;
    return result ;  
}

Console.WriteLine("Введите трехзначное число");
int number =  Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000 || number < -99 && number > -1000)
{
    if(number > 99 && number < 1000)
    {
        Console.WriteLine($"Вторая цифра числа {number} является {twonumber(number)}");

    }
    else
    {
        Console.WriteLine($"Вторая цифра числа {number} является {twonumber(number) * -1}");

    }
}
else
{
    Console.WriteLine("Введено не трехзначное число");

}


int twonumber1(int a1)
{   int result1;
    if(a1 > 99 && a1 < 1000 || a1 < -99 && a1 > -1000)
    {
        if(a1 > 99 && a1 < 1000)
        {
            result1 = a1 / 10 ;
            result1 = result1 % 10;
            return result1 ;  

        }
        else
        {
            result1 = a1 / 10 ;
            result1 = result1 % 10 * -1;
            return result1 ;
        }
    }
    else
    {
        return -1;  
    }
}
Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(twonumber1(number1));

//Какой из этих вариантов более правильный? 

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int threenumber( int number3)
{   int result2;
    if(number3 > 999  ||  number3 < -999)
        {
            while(number3 > 1000 || number3 < -1000)
            number3 = number3 / 10;
        }    
    
    if(number3 > 99 && number3 < 1000 || number3 < -99 && number3 > -1000)
     {
        if(number3 > 99 && number3 < 1000)
         {            
            result2 = number3 % 10;
            return result2 ;  
        }
        else
        {
            result2 = number3 % 10 * -1;
            return result2 ;
        }
    }
    else
    {
        return -1;
    }
}
Console.WriteLine("Введите число для определения третьей цифры");
int number3 = Convert.ToInt32(Console.ReadLine());
int endresult = threenumber(number3);
if(endresult == -1)
{
    Console.WriteLine("Нет треьей цифры");  
} 
else
{
    Console.WriteLine($"Третья цифра числа равна {endresult}");
}




//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool FunnyDay(int numberday)
{
    if(numberday == 6 || numberday == 7)
    {
        return true;
    }
    else
    {
        
        return false;
        
    }

}

Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day < 8)
{
    Console.WriteLine(FunnyDay(day));
}
else
{
    Console.WriteLine("Ошибка, нет такого дня недели");
}


