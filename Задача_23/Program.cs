// Программа, которая принимает на вход число N 
// и выдает таблицу кубов чисел от 1 до N.

void PrintCoob(int n)

{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i * i);
    }

}


PrintCoob(3);