//stranisa_33_nomer_3
Console.Write("Введите натуральное число n:");
int n = int.Parse(Console.ReadLine());
double product = 1.0;
for (double k = 1.0; k <= n; k++)
{
    double P = (2 * k) / (2 * k + 1);
    product *= P;
}
Console.WriteLine($"Произведение первых {n} сомножителей:{product}");