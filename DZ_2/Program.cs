// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int numb = Convert.ToInt32 (Console.ReadLine());
if(numb<99)
{
    Console.WriteLine("третьей цифры нет");
}
else{string str=numb.ToString();
 Console.WriteLine(           str[2]);
}
     
     
        
       
