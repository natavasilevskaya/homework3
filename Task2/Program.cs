// Напишите программу, которая принимает на вход число (N) и выдаёт кубы чисел от 1 до N.

void СubeNumber (int num)
{
    for (int i = 1 ;i<=num;i++)
    {
        Console.WriteLine(i * i * i + " ");
    }
}

Console.WriteLine("Input number: ");
int сube = Convert.ToInt32(Console.ReadLine());

СubeNumber (сube);