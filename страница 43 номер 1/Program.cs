//stranisa_43_1
Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine());
int F = 0;
int Z = n % 10;
while (n > 0)
{
    F = n % 10;
    n /= 10;
    if (n < 10)
        break;
}
int sum = F + Z;
Console.WriteLine($"Сумма первой и последней цифры числа: {sum}");