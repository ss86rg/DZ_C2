//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

string[] week = { "понеделеньник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

Console.Write("Введите число деня недели: ");
string weekday = Console.ReadLine();

int dayNamber = Convert.ToInt32(weekday);

if (dayNamber > 5)
{
    Console.WriteLine("выходной день");
}
if
(dayNamber < 0 || dayNamber > 7)
{
    Console.WriteLine("нет такого дня недели");
}
else
{
    Console.WriteLine(week[dayNamber - 1]);
}

