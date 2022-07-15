Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"{a} больше, чем {b}");
}
else {
    Console.WriteLine($"{b} больше, чем {a}");}
