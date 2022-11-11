// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());

if(numDay == 1)Console.WriteLine("Первый день недели это Понедельник");
else if(numDay == 2) Console.WriteLine("Второй день недели это Вторник");
else if(numDay == 3) Console.WriteLine("Третий день недели это Среда");
else if(numDay == 4) Console.WriteLine("Четвертый день недели это Четверг");
else if(numDay == 5) Console.WriteLine("Пятый день недели это Пятница");
else if(numDay == 6) Console.WriteLine("Шестой день недели это Суббота");
else if(numDay == 7) Console.WriteLine("Седьмой день недели это Воскресенье");
else Console.WriteLine("Такого дня недели нет.");