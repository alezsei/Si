//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



 Console.WriteLine("Ввведите первое число");
 int a1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввведите второе число");
 int b1 = Convert.ToInt32(Console.ReadLine());
 if(a1 > b1)
 {
    Console.WriteLine($"Большим из чисел {a1} и {b1} - является {a1}, меньшим является {b1}");
 }
 else if(a1 < b1)
 {
    Console.WriteLine($"Большим из чисел {a1} и {b1} - является {b1}, меньшим является {a1}");
 }
else
{
   Console.WriteLine($"Числа {a1} и {b1} равны");
}

 //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

 Console.WriteLine("Ввведите первое число");
 int a2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввведите второе число");
 int b2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Ввведите третье число");
 int c2 = Convert.ToInt32(Console.ReadLine());
 if(a2 >= b2)

 {
   if(a2 > c2)
   {
      if(a2 != b2)
      {
         Console.WriteLine($"Большим из трех чисел является {a2}");
      } 
      else 
      {
         Console.WriteLine($"Максимальное значение имеют несколько чисел и их значение равно - {a2}");
      }
   }
   else if(a2 == c2)
   {
      Console.WriteLine($"Максимальное значение имеют несколько чисел и их значение равно - {a2}");
   }
   else
   {
      Console.WriteLine($"Большим из трех чисел является {c2}");
   }
 }
else
{
   if(b2 > c2)
   {
      Console.WriteLine($"Большим из трех чисел является {b2}");

   }
   else if(b2 == c2)
   {
      Console.WriteLine($"Максимальное значение имеют несколько чисел и их значение равно - {b2}");
   }  
   else
   {
      Console.WriteLine($"Большим из трех чисел является {c2}");
   }
}


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ввведите проверяемое число");
int a4 = Convert.ToInt32(Console.ReadLine());
if(a4 % 2 == 0)
{
   Console.WriteLine("Число " + a4 + " четное");
}
else 
{
   Console.WriteLine("Число " + a4 + " нечетное");
}   


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Ввведите число N");
int a5 = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(a5 > 0)
{
   while(count <= a5)
   {
      if(count % 2 == 0)
      {
         Console.WriteLine(count);
         count++;
      }
      else
      {
         if(a5 == 1)
         {
            Console.WriteLine("Таких чисел нет");

         }
         count++;
      }
   }
}
else
{
   while(count >= a5)
   {
      if(count % 2 == 0)
      {
         Console.WriteLine(count);
         count--;
      }
      else
      {
         count--;
      }
   }
}
