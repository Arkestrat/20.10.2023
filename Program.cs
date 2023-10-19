//stranisa36_1b
double e = double.Parse(Console.ReadLine());
double sum = 0;
while (true)
{
    double r = double.Parse(Console.ReadLine());
    r = (1 / Math.Pow(2, r) + 1 / Math.Pow(3, r));
    if (Math.Abs(r) >= e)
    {
        sum += r;
    }
    Console.WriteLine("Продольжить последовательность? Y/N");
    if (Console.ReadLine() == "N")
    {
        break;
    }

}
Console.WriteLine(sum);