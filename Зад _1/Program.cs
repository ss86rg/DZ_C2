//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool Validate2sign(int number)
{
    if (number >= 10 && number < 1000)
    {
        return true;
    }

    System.Console.WriteLine("Число не трехзначное");
    return false;
}

int num = ReadInt("Введите число -> ");
if (Validate2sign(num))
{
    int SecondDigit = (num % 100)/10;
    System.Console.WriteLine($"Вторая цифра числа {num} равна {SecondDigit}");
}


