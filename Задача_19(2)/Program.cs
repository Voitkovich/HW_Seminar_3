// Метод.

void Palindrom(int number)
{
// здесь хранится число, которое будем реверсировать
int reversNumber = number;
//здесь будет записываться новое число - результат реверса
int revers = 0;

while(reversNumber > 0) // будем перебирать число пока оно больше 0
{
    // будем записывать в переменную "revers" цифры. Меняем местами первые и последние цифры с помощью % & /
    revers = (revers * 10) + reversNumber % 10;
    reversNumber /=10;
}
// Запоминаем новое число
 Console.Write(revers);
 // Сравниваем новое число со старым
 if (number == revers)

 {
    Console.WriteLine("  - Это палиндром! ");
 }
else
{
    Console.WriteLine(" -  Это не палиндром! ");
}
}
Palindrom(12343);

