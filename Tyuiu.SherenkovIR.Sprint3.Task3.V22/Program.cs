using Tyuiu.SherenkovIR.Sprint3.Task3.V22.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #3                                        *");
Console.WriteLine("* Тема:Оператор цикла foreach                      *");
Console.WriteLine("* Задание #3                                       *");
Console.WriteLine("* Вариант #22                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Используя цикл foreach подсчитать максимальное   *");  
Console.WriteLine("* количество букв b, находящихся на соседних       *");
Console.WriteLine("* позициях в строке: tbtbbb dsfbg bbg              *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

string value = "  bdd bdd bdd bdd bdd ";
char chr = 'b';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Искомый символ = " + chr);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("Количество символов = " + ds.GetMaxCharCount(value, chr));

Console.ReadKey();
