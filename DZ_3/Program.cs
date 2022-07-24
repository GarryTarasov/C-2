// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цивру (число) в пределе от 1 до 7 включительно. эквивалент семи дням недели.");
int numb = Convert.ToInt32 (Console.ReadLine());
if(numb>7)
{
    Console.WriteLine("Тебе же сказали, от 1 до 7 включительно. Попробуй еще раз");
}   
    else if(numb<1)
        {
        Console.WriteLine("Тебе же сказали, от 1 до 7 включительно. Попробуй еще раз");
        }
        else if(numb==7)
        {Console.WriteLine("выходной");}
        else if(numb==6)
        { Console.WriteLine("выходной");}
        else{ Console.WriteLine(" Не выходной");}