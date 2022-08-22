// Данная программа выводит третью цифру случайно сгенерированного числа от 1 до 65536
int randomnum = new Random().Next(1, 65537);
Console.WriteLine("Случайно сгенерированное число: " + randomnum);
int thirddigit; // переменная для записи третьей цифры
if (randomnum / 10000 > 0)
{
   thirddigit = (randomnum % 1000) / 100;
}
else
 if (randomnum / 1000 > 0)
{
   thirddigit = (randomnum % 100) / 10;
}
else
  if (randomnum / 100 > 0)
{
   thirddigit = randomnum % 10;
}
else 
   thirddigit = -1;
//Вывод результата   
if (thirddigit == -1) 
   Console.WriteLine("Третьей цифры нет");
else 
   Console.WriteLine("Третья цифра: " + thirddigit);
