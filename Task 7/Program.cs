using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint goldAmount;
        uint gemsAmount = 0;
        uint gemsRate = 100;

        Console.Write("Введите стартовое количество золота - ");
        goldAmount = Convert.ToUInt32(Console.ReadLine());
        Console.Write($"Сколько кристаллов хотите купить по курсу {gemsRate} золота за кристалл? \t");
        gemsAmount = Convert.ToUInt32(Console.ReadLine());
        goldAmount -= gemsRate * gemsAmount;
        Console.WriteLine($"У вас имеется {goldAmount} золота и {gemsAmount} кристаллов");
    }
}
