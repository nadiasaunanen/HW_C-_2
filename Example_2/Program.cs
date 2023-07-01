// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit < 100) Console.WriteLine("Третьей цифры нет");

while (digit > 1000) 
{
    digit /= 10;    
}
   
    return digit % 10;
object value = Console.WriteLine($"Третье число в указанном:  {digit}");

// if (digit < 1000 && digit > 99) digit /= 100; Console.WriteLine($"Третья цифра: {digit}");