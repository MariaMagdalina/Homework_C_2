﻿//данная программа выводит вторую цифру случайно сгенерированного трехзначного числа
int randomnum = new Random().Next (100,1000);
Console.WriteLine("Случайно сгенерированное трехзначное число: " + randomnum);
Console.WriteLine("Вторая цифра в данном числе: " + (randomnum % 100) / 10);