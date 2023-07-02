// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());


while (digit > 1000)
{
    digit /= 10;  
}     
    }
    returne digit % 10;

bool temp (int digit)
{
    if (digit < 100) return false; else return true;
}
    if ((digit) != true)
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        System.Console.WriteLine($"Третья цифра числа {digit} является {fdigit(digit)}");
    }

//Не могу понять как написать код