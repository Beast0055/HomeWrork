Console.WriteLine("Введите данные");
int num = int.Parse(Console.ReadLine());

if (num >= 100  && num < 1000)
{
    Console.WriteLine(num % 10);
}
else{
    Console.WriteLine("Третьей цифры нет");
}
