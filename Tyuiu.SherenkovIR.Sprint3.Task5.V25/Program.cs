using Tyuiu.SherenkovIR.Sprint3.Task5.V25.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #3                                        *");
Console.WriteLine("* Тема:Вложенные циклы                             *");
Console.WriteLine("* Задание #5                                       *");
Console.WriteLine("* Вариант #25                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Вычисляет значение формулы                        *");
Console.WriteLine("*y = Σ(i=1 to 3) Σ(k=1 to 10) (x^k + cos(k)) при x=2*");
Console.WriteLine("*                                                  *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int x = 2;
int startValue1 = 1;
int startValue2 = 3;
int stopValue1 = 1;
int stopValue2 = 10;

Console.WriteLine("Переменная X =" + x);
Console.WriteLine("Старт шага первой суммы ряда =" + startValue1);
Console.WriteLine("Конец шага первой суммы ряда =" + startValue2);
Console.WriteLine("Старт шага второй суммы ряда =" + stopValue1);
Console.WriteLine("Конец шага второй суммы ряда =" + stopValue2);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();

