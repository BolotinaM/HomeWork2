// задание 2


int Number(int num)
{
    Console.WriteLine(num);
var str = num.ToString();
num = int.Parse(str.Remove(str.Length - 2, 1));
return (num);
}

Console.WriteLine(Number (new Random().Next(100, 999)));