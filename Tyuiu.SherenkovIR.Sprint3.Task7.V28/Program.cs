using Tyuiu.SherenkovIR.Sprint3.Task7.V28.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #3                                        *");
Console.WriteLine("* Тема:Добавление к решению итоговых проектов      *");
Console.WriteLine("* Тема: по спринту                                 *");
Console.WriteLine("* Задание #7                                       *");
Console.WriteLine("* Вариант #28                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Написать программу которая выводит таблицу значени*");
Console.WriteLine("*функции Cos(2 * x) + Sin(x) / (x + 2.5) + 2 * x   *");
Console.WriteLine("*роизвести табулирование f(x) на заданном диапазоне*");
Console.WriteLine("*[-5;5] с шагом 1. Произвести проверку деления на 0*");
Console.WriteLine("*При делении на 0 вернуть значение 0               *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int startValue = -5;
int stopValue = 5;
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine(" Конец шага = " + stopValue);

int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startValue, stopValue);
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("+---------+---------+");
Console.WriteLine("|    X    |   f(x)  |");
Console.WriteLine("+---------+---------+");
for (int i = 0; i <= len-1; i++)
{
    Console.WriteLine("|{0,5:d}    |  {1, 6:f2} |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+--------+--------+");
Console.ReadKey();