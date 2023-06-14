//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate2sign(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }

    System.Console.WriteLine("третьей цыфры нет");
    return false;
}

int num = ReadInt("Введите число -> ");
if (Validate2sign(num))
{
    int lastDigit = num % 10;
    System.Console.WriteLine($"Третья цифра числа {num} равна {lastDigit}");
}
