// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом (работает только с 5-значными натуральными 
//положительными числами)

void PalindromCheck(string num)
{
if (num[0]==num[4] || num[1]==num[3])
{
    Console.WriteLine("Number " + num + " is palindrom!");
}
else 
{
    Console.WriteLine("Number " + num + " is not palindrom!");
}
}

Console.WriteLine("Input five digit number:");
string num = Console.ReadLine();

PalindromCheck(num);

