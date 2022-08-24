// Данная программа выводит третью цифру случайно сгенерированного числа 
long randomnum = new Random().Next(1, 1000000000);
Console.WriteLine("Случайно сгенерированное число: " + randomnum);

// определение количества разрядов в числе
int i = 10; // переменная для подсчета разрядности числа, присвоили значение 10 для избежания лишнего действия в цикле.  
bool t = false;
while(t == false)
{ 
   if(randomnum/i > 0)
      i = i*10;  
   else 
      t = true;    
}
// в результате значение разрядности получается в 10 раз больше, учтем это в дальнейшем в формуле получения третьей цифры  
if(i <= 100)
   Console.WriteLine("Третьей цифры в числе нет");
else if(i >= 10000)
  {
    long digit_third = (randomnum / (i / 1000)) % 10;
    Console.WriteLine("Третья цифра в числе: " + digit_third); 
  }
else
{ 
    long digit_third = randomnum % 10;   
    Console.WriteLine("Третья цифра в числе: " + digit_third);  
}