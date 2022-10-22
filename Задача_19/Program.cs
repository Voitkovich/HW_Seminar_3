// Программа, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.



Console.WriteLine("Введите пятизначное число ");
string num = (Console.ReadLine());

string array = num;
char[] obrArray = array.ToCharArray();


Array.Reverse(obrArray);
string newArray = new string(obrArray);

if (array == newArray)
{
    Console.WriteLine("Это палиндром!");
}
if (array != newArray)
{
    Console.WriteLine("Это не палиндром!");
}

