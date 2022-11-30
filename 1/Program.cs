// задание 1

int Number(int num)
{
    Console.WriteLine(num);
    num = num / 10;
    return num % 10;
}

Console.WriteLine(Number (new Random().Next(100, 999)));