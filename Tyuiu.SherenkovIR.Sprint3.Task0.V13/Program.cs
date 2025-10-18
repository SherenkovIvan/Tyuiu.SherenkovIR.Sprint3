using Tyuiu.SherenkovIR.Sprint3.Task0.V13.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #3                                        *");
Console.WriteLine("* Тема:Оператор цикла for                          *");
Console.WriteLine("* Задание #0                                       *");
Console.WriteLine("* Вариант #13                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу используя цикл for, которая   *");
Console.WriteLine("* вычисляет сумму ряда по формуле, при a=0,5       *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
double value = 0.5;
int startValue = 1;
int stopValue = 20;
Console.WriteLine("Переменная X=" + value);
Console.WriteLine("Старт шага =" +startValue);
Console.WriteLine("Конец шага =" + stopValue);
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
Console.WriteLine(" Сумма ряда =" + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();
