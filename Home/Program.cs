Console.WriteLine("Введите данные");
int num = int.Parse(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int printNum = num / 10;
    Console.WriteLine(printNum % 10);
}


