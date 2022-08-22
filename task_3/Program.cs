// Данная программа получает на вход цифру, соответствующую дню недели, и выводит сообщение  - выходной это или нет. 
Console.Write("Введите цифру от 1 до 7 ");
int dayofweek = Convert.ToInt32(Console.ReadLine());
if(dayofweek == 6 || dayofweek == 7)
   Console.WriteLine("Это выходной!!!");
else 
   Console.WriteLine("Это не выходной :(");